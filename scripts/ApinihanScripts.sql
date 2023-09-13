
-- This query shows the information of clients who have spent more than $100,000
USE Apinihan
GO
SELECT Customer.CustName, Customer.CustPhone, '$' + CONVERT(VARCHAR,SUM(Event.EventPrice),1) AS [Amount Spent]
FROM Customer INNER JOIN Event ON Customer.CustomerID = Event.CustomerID
GROUP BY Customer.CustName, Customer.CustPhone
HAVING SUM(Event.EventPrice)>=100000;


-- This query selects Performer information for those who have a rating of 7 or above
-- This will be useful if clients ask for recommendations 
USE Apinihan
GO
SELECT Performer.PerformerName, Performer.PerformerRating, '$' + CONVERT(VARCHAR,Performer.PerformerCost,1) AS Cost, Performer.PerformerEmail
FROM Performer
WHERE Performer.PerformerRating>=7;


-- This query shows Event information including the price and who managed it
USE Apinihan
GO
SELECT [Event].EventID, [Event].EventName, (ManagerFirstName+' '+ManagerLastName) AS Manager, [Event].EventStartDate, [Event].EventEndDate,
 '$'+ CONVERT(VARCHAR,SUM(Event.EventPrice),1) AS 'Event Price'
FROM Manager INNER JOIN [Event] ON Manager.ManagerID = [Event].ManagerID
GROUP BY [Event].EventID, [Event].EventName, (ManagerFirstName+' '+ManagerLastName), Manager.ManagerFirstName, Manager.ManagerLastName, [Event].EventStartDate, [Event].EventEndDate;


--This Sproc will be useful to our accounting department and will reflect all Revenues & Expenses for a given month

-- @Month is the only input parameter� there is a default value of null
USE Apinihan
GO
CREATE PROCEDURE MonthlyIncomeStatement (@Month VARCHAR(20) = NULL)  
AS
BEGIN
-- Error Check: Ensure the input is not null and an integer within 1-12
    IF @Month IS NOT NULL
		IF @Month <= 12 AND @Month >= 1
			--Revenue will equal the SUM of Event prices and Expenses will reflect Salary Payable
		SELECT '$' + CONVERT(NVARCHAR,SUM(Event.EventPrice),1) AS 'Revenue', '$' + CONVERT(NVARCHAR,(CAST(SUM(DateDiff(DAY,ASSIGNMENT.AssignmentDateFrom,ASSIGNMENT.AssignmentDateTo)) AS MONEY)+1)*WORKER.WorkerSalary,1) AS 'Expenses',
		'$' + CONVERT(NVARCHAR,((SUM(Event.EventPrice)) - (DateDiff(DAY,ASSIGNMENT.AssignmentDateFrom,ASSIGNMENT.AssignmentDateTo)*WORKER.WorkerSalary)),1) AS 'Net'

	FROM Worker
		INNER JOIN Assignment
		ON Worker.WorkerID = Assignment.WorkerID
		INNER JOIN Manager
		ON Manager.ManagerID = Assignment.ManagerID
		INNER JOIN Event
		ON Manager.ManagerID = Event.ManagerID
	WHERE Month(Assignment.AssignmentDateFrom) = @Month
	GROUP BY Assignment.AssignmentDateFrom, Assignment.AssignmentDateTo, Worker.WorkerSalary
		ELSE
      SELECT 'Omitted parameter: Please Enter an Integer Corresponding to Month'
			AS 'Warning Message'

		ELSE
			SELECT  'Omitted parameter: Please Enter an Integer Corresponding to Month'
			AS 'Warning Message'
		RETURN (0) -- A successful completion returns 0
 END;

 --To test the MonthlyIncomeStatement sproc
 EXEC MonthlyIncomeStatement '2'


-- This function counts the number of Performers in a particular Event
--This scalar function was mostly created to furthur use in any view or query
CREATE FUNCTION fn_NumPerfInEvent(@InputEventName VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @NumPerf AS INT
	SELECT @NumPerf = COUNT(*)
	FROM Performer
	INNER JOIN Book ON Performer.PerformerID = Book.PerformerID
	INNER JOIN [Event] ON Book.EventID= Event.EventID
	WHERE [Event].Eventname = @InputEventName
	RETURN @NumPerf
END;

-- To test, note that this function is developed mainly for EventVarCost view
SELECT dbo.fn_NumPerfInEvent('Headphone Exhibition')


-- This function counts the amount of workers working a particular Event
-- This scalar function was created to furthur use in a view or query
CREATE FUNCTION fn_NumWorkerInEvent(@InputEventName VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @NumWorker AS INT
	SELECT @NumWorker = COUNT(*)
	FROM Worker
	INNER JOIN ASSIGNMENT ON Worker.WorkerID = Assignment.WorkerID
	INNER JOIN MANAGER ON Assignment.ManagerID = Manager.ManagerID
	INNER JOIN [Event] ON MANAGER.ManagerID = [Event].ManagerID
	WHERE [Event].Eventname = @InputEventName
	RETURN @NumWorker
END;

-- To test, note that this function is developed mainly for EventVarCost view
SELECT dbo.fn_NumWorkerInEvent('Denver Beer Festival')


-- A view for managers to see various cost of a certain Event. This will be easier for them to call for the information
-- Note that equipment is not a variable cost, so they are not included here.
-- This view has scalar function
CREATE VIEW vw_EventVarCost
AS
SELECT Manager.ManagerFirstName + ' ' + Manager.ManagerLastName AS [Manager Name],
	   [Event].EventName,
	   [Event].EventStartDate,
	   [Event].EventEndDate,
	   DATEDIFF(DAY, [Event].EventStartDate, [Event].EventEndDate) + 1 AS [Number of Days],
	   dbo.fn_NumWorkerInEvent([Event].EventName) AS [Number of Workers],
	   --SUM worker(s) cost in one Event
	   SUM((CAST(DATEDIFF(DAY, AssignmentDateFrom, AssignmentDateTo) AS MONEY) + 1) * Worker.WorkerSalary) AS [Worker Cost],
	   dbo.fn_NumPerfInEvent([Event].EventName) AS [Number of Performers],
	   --SUM Performer(s) cost in one Event
	   SUM((CAST(DATEDIFF(DAY, BookDateFrom, BookDateTo) AS MONEY) + 1) * Performer.PerformerCost) AS [Performer Cost]
FROM Manager
	INNER JOIN Assignment ON Manager.ManagerID = Assignment.ManagerID
	INNER JOIN Worker ON Assignment.WorkerID = Worker.WorkerID
	INNER JOIN [Event] ON Manager.ManagerID = [Event].ManagerID
	INNER JOIN Book ON [Event].EventID = Book.EventID
	INNER JOIN Performer ON Book.PerformerID = Performer.PerformerID
GROUP BY Manager.ManagerFirstName + ' ' + Manager.ManagerLastName, [Event].EventName, [Event].EventStartDate, [Event].EventEndDate;

-- Using EventVarCost view
SELECT [Manager Name], EventName AS [EventName], '$' + CAST([Worker Cost] AS VARCHAR) AS [Worker Cost], '$' + CAST([Performer Cost] AS VARCHAR) AS [Performer Cost]
FROM vw_EventVarCost
ORDER BY 1


-- This sproc will be useful to payroll as they can view how much each worker earned for each Event in a particular month
-- @Month is the only input parameter� there is a default value of null
CREATE PROCEDURE SalaryPayable (@InputMonth VARCHAR(5)=NULL)  
AS
BEGIN
--Error Check: Ensure the input is not null and an integer within 1-12
	IF @InputMonth IS NOT NULL
		IF ISNUMERIC(@InputMonth) = 1 AND @InputMonth BETWEEN 1 AND 12
			BEGIN
				--Select Employee Name, The Events they worked that month and salary owed 
				SELECT (Worker.WorkerFirstName + ' ' + Worker.WorkerLastName) AS 'Worker Name',
				[Event].EventName,
				Assignment.AssignmentDateFrom,
				Assignment.AssignmentDateTo,
				'$' + CONVERT(NVARCHAR,(CAST(DATEDIFF(DAY,ASSIGNMENT.AssignmentDateFrom,ASSIGNMENT.AssignmentDateTo) AS MONEY) + 1) * WORKER.WorkerSalary,1) AS SalaryPayable
				FROM Worker
				INNER JOIN Assignment
				ON Worker.WorkerID = Assignment.WorkerID
				INNER JOIN Manager
				ON Manager.ManagerID = Assignment.ManagerID
				INNER JOIN [Event]
				ON Manager.ManagerID = [Event].ManagerID
				WHERE CAST(Month(Assignment.AssignmentDateFrom) AS VARCHAR(5)) = @InputMonth
			END
		--Error check when the input is a character
		ELSE IF ISNUMERIC(@InputMonth) = 0
				SELECT 'Please select month <1-12>'
				AS 'Warning Message'
		--Error check when the inout is less than or equal to 0
		ELSE IF @InputMonth <= 0
				SELECT 'Please select month <1-12>'
				AS 'Warning Message'
	ELSE
		SELECT 'Omitted parameter: the form to use for this procedure is EXEC <1-12>' AS 'Warning Message'
END;

-- Testing the sproc
EXECUTE SalaryPayable '3'


-- This view shows all information for worker but hides their salary which is considered sensitive information
CREATE View WorkerView
AS
SELECT WorkerID, WorkerFirstName, WorkerLastName, WorkerEmail
FROM Worker
WITH CHECK OPTION;

-- To test,
SELECT * From WorkerView;
