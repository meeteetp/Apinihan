
-----------------------------------------------------------
-- Replace <data_path> with the full path to this file 
-- Ensure it ends with a backslash. 
-- E.g., C:\MyDatabases\ See line 
-----------------------------------------------------------
IF NOT EXISTS(SELECT * FROM sys.databases
          WHERE name = N'Apinihan')
	CREATE DATABASE Apinihan
GO
USE Apinihan
-- Alter the path so the script can find the CSV files 
--
DECLARE
   @data_path NVARCHAR(256);
SELECT @data_path = 'C:';
--
-- =======================================
-- Delete existing tables

IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = 'Assignment'
         )
  DROP TABLE Assignment;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Install'
         )
  DROP TABLE Install;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Book'
         )
  DROP TABLE Book;
--
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Event'
         )
  DROP TABLE [Event];
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Performer'
         )
  DROP TABLE Performer;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Customer'
         )
  DROP TABLE Customer;

IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Equipment'
         )
  DROP TABLE Equipment;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Manager'
         )
  DROP TABLE Manager;
--
IF EXISTS(
  SELECT *
  FROM sys.tables
  WHERE name = N'Worker'
         )
  DROP TABLE Worker;
--
-- Create tables
--

CREATE TABLE Performer
     (PerformerID		NVARCHAR(10) CONSTRAINT pk_Performer PRIMARY KEY,
      PerformerName		NVARCHAR(50) NOT NULL,
	  PerformerRating	INT,
	  PerformerCost		MONEY NOT NULL,
	  PerformerEmail	NVARCHAR(30),
     );
--
CREATE TABLE Equipment
     (EquipmentID		NVARCHAR(10) CONSTRAINT pk_Equipment PRIMARY KEY,
      EquipmentName		NVARCHAR(20) NOT NULL,
	  EquipmentDetail	NVARCHAR(40),
	  EquipmentCost		MONEY
     );
--
CREATE TABLE Customer
     (CustomerID		NVARCHAR(10) CONSTRAINT pk_Customer PRIMARY KEY,
      CustName			NVARCHAR(30) NOT NULL,
      CustPhone			NVARCHAR(14),
      CustEmail			NVARCHAR(30),
      
     );
--
CREATE TABLE Manager
     (ManagerID         NVARCHAR(10) CONSTRAINT pk_Manager PRIMARY KEY,
      ManagerFirstName	NVARCHAR(30) NOT NULL,
	  ManagerLastName	NVARCHAR(30)  NOT NULL,
      ManagerEmail      NVARCHAR(20) NOT NULL,
      ManagerPhone      NVARCHAR(15) NOT NULL,

     );
	 --
CREATE TABLE Worker
     (WorkerID          NVARCHAR(10) CONSTRAINT pk_Worker PRIMARY KEY,
      WorkerFirstName	NVARCHAR(30) NOT NULL,
	  WorkerLastName	NVARCHAR(30)  NOT NULL,
      WorkerSalary      MONEY NOT NULL,
      WorkerEmail       NVARCHAR(30) NOT NULL,

     );
CREATE TABLE [Event]
     (EventID			NVARCHAR(10) CONSTRAINT pk_Event PRIMARY KEY,
      ManagerID			NVARCHAR(10) CONSTRAINT fk_Manager FOREIGN KEY REFERENCES Manager(ManagerID),
	  CustomerID		NVARCHAR(10) CONSTRAINT fk_Customer FOREIGN KEY REFERENCES Customer(CustomerID),
	  EventName			NVARCHAR(50) NOT NULL,
	  EventStartDate	DATE NOT NULL,
	  EventEndDate		DATE NOT NULL,
	  EventPrice		MONEY NOT NULL,
	  EventStreet		NVARCHAR(30) NOT NULL,
	  EventCity			NVARCHAR(30) NOT NULL,
	  EventState		NVARCHAR(2) NOT NULL,
	  EventZip			INT NOT NULL,
     );
--
CREATE TABLE Book
	(EventID			NVARCHAR(10) NOT NULL,
	PerformerID			NVARCHAR(10) NOT NULL,
	BookDateFrom		DATE NOT NULL,
	BookDateTo			DATE NOT NULL,
	CONSTRAINT pk_Book	PRIMARY KEY (EventID, PerformerID, BookDateFrom, BookDateTo),
	CONSTRAINT fk_EventID1 FOREIGN KEY (EventID) REFERENCES Event(EventID),
	CONSTRAINT fk_PerformerID FOREIGN KEY (PerformerID) REFERENCES Performer(PerformerID)
	);

CREATE TABLE Install
	(EventID			NVARCHAR(10) NOT NULL,
	EquipmentID			NVARCHAR(10) NOT NULL,
	InstallDateFrom		DATE NOT NULL,
	InstallDateTo		DATE NOT NULL,
	CONSTRAINT pk_Install1 PRIMARY KEY (EventID, EquipmentID, InstallDateFrom, InstallDateTo),
	CONSTRAINT fk_EventID2 FOREIGN KEY (EventID) REFERENCES Event(EventID),
	CONSTRAINT fk_EquipmentID FOREIGN KEY (EquipmentID) REFERENCES Equipment(EquipmentID)
	);

CREATE TABLE Assignment
	(ManagerID			NVARCHAR(10) NOT NULL,
	WorkerID			NVARCHAR(10) NOT NULL,
	AssignmentDateFrom	DATE NOT NULL,
	AssignmentDateTo	DATE NOT NULL,
	CONSTRAINT pk_Install2 PRIMARY KEY (ManagerID, WorkerID, AssignmentDateFrom, AssignmentDateTo),
	CONSTRAINT fk_ManagerID FOREIGN KEY (ManagerID) REFERENCES Manager(ManagerID),
	CONSTRAINT fk_WorkerID FOREIGN KEY (WorkerID) REFERENCES Worker(WorkerID)
	);


	-- Load table data
--
-- Table 1 Performer
--
EXECUTE (N'BULK INSERT Performer FROM ''' + @data_path + N'Performer.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 2 Equipment
--
EXECUTE (N'BULK INSERT Equipment FROM ''' + @data_path + N'Equipment.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 3 Customer
--
EXECUTE (N'BULK INSERT Customer FROM ''' + @data_path + N'Customer.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 4 Manager
--
EXECUTE (N'BULK INSERT Manager FROM ''' + @data_path + N'Manager.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 5 Worker
--
EXECUTE (N'BULK INSERT Worker FROM ''' + @data_path + N'Worker.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 6 [Event]
--
EXECUTE (N'BULK INSERT Event FROM ''' + @data_path + N'Event.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 7 Book
--
EXECUTE (N'BULK INSERT Book FROM ''' + @data_path + N'Book.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 8 Install
--
EXECUTE (N'BULK INSERT Install FROM ''' + @data_path + N'Install.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');
-- Table 9 Assignment
--
EXECUTE (N'BULK INSERT Assignment FROM ''' + @data_path + N'Assignment.csv''
WITH (
    CHECK_CONSTRAINTS,
    CODEPAGE=''ACP'',
    DATAFILETYPE = ''char'',
    FIELDTERMINATOR= '','',
    ROWTERMINATOR = ''\n'',
    KEEPIDENTITY,
    TABLOCK
);');

-- ================================================
-- List table names and row counts for confirmation
--
GO
SET NOCOUNT ON
SELECT 'Performer' "Table",		COUNT(*) "Rows" FROM Performer			UNION
SELECT 'Equipment',				COUNT(*)		FROM Equipment          UNION
SELECT 'Customer',				COUNT(*)		FROM Customer			UNION
SELECT 'Manager',				COUNT(*)		FROM Manager            UNION
SELECT 'Worker',                COUNT(*)		FROM Worker             UNION
SELECT 'Event',					COUNT(*)		FROM Event				UNION
SELECT 'Book',					COUNT(*)		FROM Book               UNION
SELECT 'Install',				COUNT(*)		FROM Install			UNION
SELECT 'Assignment',			COUNT(*)		FROM Assignment
ORDER BY 1;
SET NOCOUNT OFF
GO