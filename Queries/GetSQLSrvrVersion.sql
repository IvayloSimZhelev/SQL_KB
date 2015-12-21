
IF OBJECT_ID('tempdb..#SSS') IS NOT NULL DROP TABLE #SSS
create table #SSS(ID int primary key not null IDENTITY,  Name nvarchar(512) null , Value nvarchar(512) null, Descr nvarchar(1024) null)

IF OBJECT_ID('tempdb..#server') IS NOT NULL DROP TABLE #server
create table #server(ID int, Name  sysname null, InternalVal int null, Value nvarchar(512) null)
insert #server exec master.dbo.xp_msver

declare @RegRootDir nvarchar(512)
exec master.dbo.xp_instance_regread N'HKEY_LOCAL_MACHINE', N'SOFTWARE\Microsoft\MSSQLServer\Setup', N'SQLPath', @RegRootDir OUTPUT

INSERT INTO #SSS (Name, Value, Descr)
VALUES (N'ProductName', (select Value from #server where Name = N'ProductName'), 'Product name; for example, Microsoft SQL Server.'),
       (N'Language', (select Value from #server where Name = N'Language'), 'The language version of SQL Server.'),
       (N'Platform', (select Value from #server where Name = N'Platform'), 'Operating-system name, manufacturer name, and chip family name for the computer that is running SQL Server.'),
       (N'Processors', (select Value from #server where Name = N'ProcessorCount'), 'The number of processors in the computer that is running SQL Server.'),
       (N'WindowsVer', (select Value from #server where Name = N'WindowsVersion'), 'Version of Microsoft Windows that is installed on the computer that is running SQL Server.'),
       (N'FileVersion', (select Value from #server where Name = N'FileVersion'), 'Version of the SQL Server executable.'),
       (N'PhysicalMemory', (select Value from #server where Name = N'PhysicalMemory'), 'Amount in megabytes (MB) of RAM installed on the computer that is running SQL Server.'),
       (N'LegalTrademarks', (select Value from #server where Name = N'LegalTrademarks'), 'Legal trademark information required for SQL Server. For example, Microsoft is a registered trademark of Microsoft Corporation.'),
       (N'LegalCopyright', (select Value from #server where Name = N'LegalCopyright'), 'Legal copyright information required for SQL Server; for example, Copyright© Microsoft Corp. 1988-2005.'),
       (N'OriginalFilename', (select Value from #server where Name = N'OriginalFilename'), 'File name executed at SQL Server startup; for example, Sqlservr.exe.'),
       (N'RootFolder', @RegRootDir, 'Instance') 

DECLARE @props TABLE (propertyname sysname PRIMARY KEY, Descr nvarchar(1024) null )
INSERT INTO @props(propertyname, Descr)
SELECT 'BuildClrVersion', 'Gets the BuildClrVersion property value.'
UNION
SELECT 'Collation', 'Returns the property of a specified collation in SQL Server '
UNION
SELECT 'CollationID', 'Gets the CollationID property value'
UNION
SELECT 'ComparisonStyle', 'Windows comparison style of the collation. 0 - for all binary colations.'
UNION
SELECT 'ComputerNamePhysicalNetBIOS', 'NetBIOS name of the local computer on which the instance of SQL Server is currently running. '
UNION
SELECT 'Edition', 'Installed product edition of the instance of SQL Server. '
UNION
SELECT 'EditionID', 'EditionID represents the installed product edition of the instance of SQL Server.'
UNION
SELECT 'EngineEdition', 'Database Engine edition of the instance of SQL Server installed on the server. 1 = Personal or Desktop Engine (Not available in SQL Server 2005 and later versions.). 2 = Standard (This is returned for Standard, Web, and Business Intelligence.) . 3 = Enterprise (This is returned for Evaluation, Developer, and both Enterprise editions.). 4 = Express (This is returned for Express, Express with Tools and Express with Advanced Services). 5 = SQL Database'
UNION
SELECT 'InstanceName', 'Name of the instance to which the user is connected.'
UNION
SELECT 'IsAdvancedAnalyticsInstalled', '1 if the Advanced Analytics feature was installed during setup; 0 if Advanced Analytics was not installed.'
UNION
SELECT 'IsClustered', 'Server instance is configured in a failover cluster.0 = Not Clustered. 1 = Clustered. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'IsFullTextInstalled', 'The full-text and semantic indexing components are installed on the current instance of SQL Server. 1 = Full-text and semantic indexing components are installed. 0 = Full-text and semantic indexing components are not installed. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'IsIntegratedSecurityOnly', 'Server is in integrated security mode. 0 = Not integrated security. (Both Windows Authentication and SQL Server Authentication.). 1 = Integrated security (Windows Authentication). NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'IsPolybaseInstalled', 'Whether the server instance has the PolyBase feature installed. 0 = PolyBase is not installed. 1 = PolyBase is installed.'
UNION
SELECT 'IsSingleUser', 'Server is in single-user mode. 0 = Not single user. 1 = Single user. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'IsLocalDB', 'Server is an instance of SQL Server Express LocalDB. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'IsXTPSupported', 'Server supports In-Memory OLTP. 0= Server does not supports In-Memory OLTP. 1= Server supports In-Memory OLTP. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'LCID', 'Windows locale identifier (LCID) of the collation.'
UNION
SELECT 'MachineName', 'Windows computer name on which the server instance is running. For a clustered instance, an instance of SQL Server running on a virtual server on Microsoft Cluster Service, it returns the name of the virtual server. NULL = Input is not valid, an error, or not applicable.'
UNION
SELECT 'ProcessID', 'Process ID of the SQL Server service. ProcessID is useful in identifying which Sqlservr.exe belongs to this instance.'
UNION
SELECT 'ProductBuild' , 'The build number. Applies to: SQL Server 2014 beginning October, 2015.'
UNION
SELECT 'ProductBuildType' , 'Type of build of the current build. OD = On Demand release a specific customer. GDR = General Distribution Release released through windows update. NULL = Not applicable.'
UNION
SELECT 'ProductLevel', 'Level of the version of the instance of SQL Server. RTM = Original release version. SPn = Service pack version. CTPn = Community Technology Preview version'
UNION
SELECT 'ProductMajorVersion', 'The major version. Applies to: SQL Server 2014 beginning October, 2015.'
UNION
SELECT 'ProductMinorVersion', 'The minor version. Applies to: SQL Server 2014 beginning October, 2015.'
UNION
SELECT 'ProductUpdateLevel', 'Update level of the current build. CU indicates a cumulative update. CUn = Cumulative Update. NULL = Not applicable.'
UNION
SELECT 'ProductUpdateReference', 'KB article for that release. Applies to: SQL Server 2014 beginning October, 2015.'
UNION
SELECT 'ProductVersion' , 'Version of the instance of SQL Server, in the form of /major.minor.build.revision/.'
UNION
SELECT 'ResourceLastUpdateDateTime', 'The date and time that the Resource database was last updated.'
UNION
SELECT 'ResourceVersion', 'The resource database version.'
UNION
SELECT 'ServerName', 'Both the Windows server and instance information associated with a specified instance of SQL Server.'
UNION
SELECT 'SqlCharSet', 'The SQL character set ID from the collation ID.'
UNION
SELECT 'SqlCharSetName', 'The SQL character set name from the collation.'
UNION
SELECT 'SqlSortOrder', 'The SQL sort order ID from the collation'
UNION
SELECT 'SqlSortOrderName', 'The SQL sort order name from the collation.'
UNION
SELECT 'FilestreamShareName', 'The name of the share used by FILESTREAM.'
UNION
SELECT 'FilestreamConfiguredLevel', 'The configured level of FILESTREAM access. For more information, see filestream access level.'
UNION
SELECT 'FilestreamEffectiveLevel', 'The effective level of FILESTREAM access. This value can be different than the FilestreamConfiguredLevel if the level has changed and either an instance restart or a computer restart is pending. For more information, see filestream access level.'
 
INSERT INTO #SSS (Name, Value, Descr)
SELECT Convert(nvarchar, propertyname), Convert(nvarchar, SERVERPROPERTY(propertyname)), Descr FROM @props;

INSERT INTO #SSS (Name, Value, Descr)
VALUES('CONNECTIONS', CONVERT(nvarchar(MAX), @@CONNECTIONS), 'The number of logins or attempted logins since SQL Server was last started'),
('CPU Busy', CONVERT(nvarchar(MAX), (@@CPU_BUSY * (@@TIMETICKS / 1000))), 'The Number of seconds CPU has spent Working since SQL Server was last started'),
('Cursor Rows',CONVERT(nvarchar(MAX),  @@CURSOR_ROWS), 'Number of rows currently in the last opened cursor (for the current connection)'),
('Date First', CONVERT(nvarchar(MAX), @@DATEFIRST), 'First day of the week. 1 for Monday, 2 for Tuesday, etc. Default is 7(Sunday).'), 
('DB Time Stamp', CONVERT(nvarchar(MAX), @@DBTS, 1), 'The last-used timestamp value of the current database. A new timestamp value is generated when a row with a timestamp column is inserted or updated.timestamp is guaranteed to be unique in the database.'),
('Default Lang ID', CONVERT(nvarchar(MAX), @@DEFAULT_LANGID), ''),
('Identity', CONVERT(nvarchar(MAX), @@IDENTITY), 'Returns the last IDENTITY value inserted. If there havent been any IDENTITY values inserted than this variable is NULL.'),
('Iddle', CONVERT(nvarchar(MAX), @@IDLE), 'Number of milliseconds SQL Server has been idle since it was last started'),
('I/O Busy', CONVERT(nvarchar(MAX), @@IO_BUSY), 'The amount of time, in ticks, that SQL Server has spent doing input and output operations    since it was last started. i.e Number of milliseconds SQL Server has spent performing Input and Output (IO) operations since it was last started'), 
('Lang ID', CONVERT(nvarchar(MAX), @@LANGID), 'Language ID'),
('Language Name', CONVERT(nvarchar(MAX), @@LANGUAGE), 'Language Name'),
('Lock TimeOut',CONVERT(nvarchar(MAX),  @@LOCK_TIMEOUT), 'current lock time-out setting in milliseconds for the current session.SET LOCK_TIMEOUT allows an application to set the maximum time that a statement waits on a blocked resource. When a statement has waited longer than the LOCK_TIMEOUT setting, the blocked statement is automatically canceled, and an error message is returned to the application.'),
('Max Connection', CONVERT(nvarchar(MAX), @@MAX_CONNECTIONS), 'max # connections allowed simultaneously to server'),
('Max precision', CONVERT(nvarchar(MAX), @@MAX_PRECISION), 'Max Precision'),
('MS Version code', CONVERT(nvarchar(MAX), CAST(@@MICROSOFTVERSION as binary(10)), 2), 'SQL Server version Hex Code.'),
('Nesting sp level', CONVERT(nvarchar(MAX), @@NESTLEVEL), 'Returns the nesting level of the current stored procedure execution (initially 0) on the local server. Each time a stored procedure calls another stored procedure or executes managed code by referencing a common language runtime (CLR) routine, type, or aggregate, the nesting level is incremented. When the maximum of 32 is exceeded, the transaction is terminated. When @@NESTLEVEL is executed within a Transact-SQL string, the value returned is 1 + the current nesting level. When @@NESTLEVEL is executed dynamically by using sp_executesql the value returned is 2 + the current nesting level.'),
('Options',CONVERT(nvarchar(MAX), @@OPTIONS), 'Returns information about the current SET options (max 15). The @@OPTIONS function returns a bitmap of the options, converted to a base 10 (decimal) integer. The bit settings are stored in the locations described in the topic Configure the user options Server Configuration Option. To decode the @@OPTIONS value, convert the integer returned by @@OPTIONS to binary, and then look up the values on the table above.'),
('Packet recieved', CONVERT(nvarchar(MAX), @@PACK_RECEIVED), 'A number of input packets read from the network by SQL Server since it was last started'),
('Packet sent', CONVERT(nvarchar(MAX), @@PACK_SENT), 'A number of output packets written to the network by SQL Server since it was last started'),
('Packet Errors', CONVERT(nvarchar(MAX), @@PACKET_ERRORS), 'A number of network packet errors that have occurred on SQL Server connections since SQL Server was last started'),
('Remote SQL Server', CONVERT(nvarchar(MAX), @@REMSERVER), 'Remote SQL Server, it being deprecated.'),
('Row Count', CONVERT(nvarchar(MAX), @@ROWCOUNT), 'A number of rows affected by the last statement'),
('Server Name', CONVERT(nvarchar(MAX), @@SERVERNAME), 'Server NameDefault instance ‘servername’ / Named instance ‘servername\instancename’ / failover clustered instance – default instance ‘virtualservername’ /  failover clustered instance – named instance ‘virtualservername\instancename’'),
('Service Name', CONVERT(nvarchar(MAX), @@SERVICENAME), 'Service Name. ServiceName,–CURRENT INSTANCE DEFAULT/INSTANCE NAME'),
('Max Text Size', CONVERT(nvarchar(MAX), @@TEXTSIZE), 'Text Size Specifies the size of varchar(max), nvarchar(max), varbinary(max), text, ntext, and image data returned by a SELECT statement.'),
('Time Ticks', CONVERT(nvarchar(MAX), @@TIMETICKS), 'Time Ticks. Returns the number of microseconds per tick. The amount of time per tick is computer-dependent. Each tick on the operating system is 31.25 milliseconds, or one thirty-second of a second.'),
('Total Errors', CONVERT(nvarchar(MAX), @@TOTAL_ERRORS), 'Returns the number of disk write errors encountered by SQL Server since SQL Server last started. Not all write errors encountered by SQL Server are accounted for by this function. Occasional non-fatal write errors are handled by the server itself and are not considered errors. To display a report containing several SQL Server statistics, including total number of errors, run sp_monitor.'),
('Total Reads', CONVERT(nvarchar(MAX), @@TOTAL_READ), 'A number of disk reads, not cache reads, by SQL Server since SQL Server was last started'), 
('Total Writes', CONVERT(nvarchar(MAX), @@TOTAL_WRITE), 'A number of disk writes by SQL Server since SQL Server was last started'),
('Transaction numbers', CONVERT(nvarchar, @@TRANCOUNT), 'A number of active transactions for the current connection'),
('SQL Server Version', CONVERT(nvarchar(MAX), @@VERSION), 'Returns system and build information for the current installation of SQL Server.')

SELECT * FROM #SSS

drop table #server
drop table #SSS

