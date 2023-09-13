
-----------------------------------------------------------
-- Replace <data_path> with the full path to this file 
-- Ensure it ends with a backslash. 
-- E.g., C:\MyDatabases\ See line 
-----------------------------------------------------------
-- Updating/Creating USERNAMEPASSWORD table


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
  WHERE name = 'USERNAMEPASS'
         )
  DROP TABLE USERNAMEPASS;
  
--
CREATE TABLE Usernamepass
     (Username         NVARCHAR(50) CONSTRAINT pk_Username PRIMARY KEY,
      Password	NVARCHAR(50) NOT NULL,
	  Position NVARCHAR(20) NOT NULL
	  )
	  ;

	-- Load table data
--
-- Table Performer
--
EXECUTE (N'BULK INSERT Usernamepass FROM ''' + @data_path + N'USERNAMEPASS.csv''
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
SELECT 'Assignment',			COUNT(*)		FROM Assignment			UNION
SELECT 'Usernamepass',			COUNT(*)		FROM Usernamepass		
ORDER BY 1;
SET NOCOUNT OFF
GO