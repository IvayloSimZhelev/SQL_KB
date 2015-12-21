using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_KB
{

    public class Pair
    {
        public readonly string Name = "";
        public readonly string Value = "";
        public readonly string Descr = "";
        public Pair(string name1, string value1, string descr1 )
        {
            Name = name1;
            Value = value1;
            Descr = descr1;
        } 
    }
    
    public class SQL
    {
        public string SQLIP { get; set; }
        public string SQLName { get; set; }

        public Pair ProductName = new Pair("ProductName", "", "Product name; for example, Microsoft SQL Server.");
        public Pair Language = new Pair("Language", "", "The language version of SQL Server.");
        public Pair Platform = new Pair("Platform", "", "Operating-system name, manufacturer name, and chip family name for the computer that is running SQL Server.");
        public Pair Processors = new Pair("Processors", "", "The number of processors in the computer that is running SQL Server.");
        public Pair WindowsVer = new Pair("WindowsVer", "", "Version of Microsoft Windows that is installed on the computer that is running SQL Server.");
        public Pair FileVersion = new Pair("FileVersion", "", "Version of the SQL Server executable.");
        public Pair PhysicalMemory = new Pair("PhysicalMemory", "", "Amount in megabytes (MB) of RAM installed on the computer that is running SQL Server.");
        public Pair LegalTrademarks = new Pair("LegalTrademarks", "", "Legal trademark information required for SQL Server. For example, Microsoft is a registered trademark of Microsoft Corporation.");
        public Pair LegalCopyright = new Pair("LegalCopyright", "", "Legal copyright information required for SQL Server; for example, Copyright© Microsoft Corp. 1988-2005.");
        public Pair OriginalFilename = new Pair("OriginalFilename", "", "File name executed at SQL Server startup; for example, Sqlservr.exe.");
        public Pair RootFolder = new Pair("RootFolder", "", "Instance");
        public Pair BuildClrVersion = new Pair("BuildClrVersion", "", "Gets the BuildClrVersion property value.");
        public Pair Collation = new Pair("Collation", "", "Returns the property of a specified collation in SQL Server ");
        public Pair CollationID = new Pair("CollationID", "", "Gets the CollationID property value");
        public Pair ComparisonStyle = new Pair("ComparisonStyle", "", "Windows comparison style of the collation. 0 - for all binary colations.");
        public Pair ComputerNamePhysicalNetBIOS = new Pair("ComputerNamePhysicalNetBIOS", "", "NetBIOS name of the local computer on which the instance of SQL Server is currently running. ");
        public Pair Edition = new Pair("Edition", "", "Installed product edition of the instance of SQL Server. ");
        public Pair EditionID = new Pair("EditionID", "", "EditionID represents the installed product edition of the instance of SQL Server.");
        public Pair EngineEdition = new Pair("EngineEdition", "", "Database Engine edition of the instance of SQL Server installed on the server. 1 = Personal or Desktop Engine (Not available in SQL Server 2005 and later versions.). 2 = Standard (This is returned for Standard, Web, and Business Intelligence.) . 3 = Enterprise (This is returned for Evaluation, Developer, and both Enterprise editions.). 4 = Express (This is returned for Express, Express with Tools and Express with Advanced Services). 5 = SQL Database");
        public Pair FilestreamConfiguredLevel = new Pair("FilestreamConfiguredLevel", "", "The configured level of FILESTREAM access. For more information, see filestream access level.");
        public Pair FilestreamEffectiveLevel = new Pair("FilestreamEffectiveLevel", "", "The effective level of FILESTREAM access. This value can be different than the FilestreamConfiguredLevel if the level has changed and either an instance restart or a computer restart is pending. For more information, see filestream access level.");
        public Pair FilestreamShareName = new Pair("FilestreamShareName", "", "The name of the share used by FILESTREAM.");
        public Pair InstanceName = new Pair("InstanceName", "", "Name of the instance to which the user is connected.");
        public Pair IsAdvancedAnalyticsInstalled = new Pair("IsAdvancedAnalyticsInstalled", "", "1 if the Advanced Analytics feature was installed during setup; 0 if Advanced Analytics was not installed.");
        public Pair IsClustered = new Pair("IsClustered", "", "Server instance is configured in a failover cluster.0 = Not Clustered. 1 = Clustered. NULL = Input is not valid, an error, or not applicable.");
        public Pair IsFullTextInstalled = new Pair("IsFullTextInstalled", "", "The full-text and semantic indexing components are installed on the current instance of SQL Server. 1 = Full-text and semantic indexing components are installed. 0 = Full-text and semantic indexing components are not installed. NULL = Input is not valid, an error, or not applicable.");
        public Pair IsIntegratedSecurityOnly = new Pair("IsIntegratedSecurityOnly", "", "Server is in integrated security mode. 0 = Not integrated security. (Both Windows Authentication and SQL Server Authentication.). 1 = Integrated security (Windows Authentication). NULL = Input is not valid, an error, or not applicable.");
        public Pair IsLocalDB = new Pair("IsLocalDB", "", "Server is an instance of SQL Server Express LocalDB. NULL = Input is not valid, an error, or not applicable.");
        public Pair IsPolybaseInstalled = new Pair("IsPolybaseInstalled", "", "Whether the server instance has the PolyBase feature installed. 0 = PolyBase is not installed. 1 = PolyBase is installed.");
        public Pair IsSingleUser = new Pair("IsSingleUser", "", "Server is in single-user mode. 0 = Not single user. 1 = Single user. NULL = Input is not valid, an error, or not applicable.");
        public Pair IsXTPSupported = new Pair("IsXTPSupported", "", "Server supports In-Memory OLTP. 0= Server does not supports In-Memory OLTP. 1= Server supports In-Memory OLTP. NULL = Input is not valid, an error, or not applicable.");
        public Pair LCID = new Pair("LCID", "", "Windows locale identifier (LCID) of the collation.");
        public Pair MachineName = new Pair("MachineName", "", "Windows computer name on which the server instance is running. For a clustered instance, an instance of SQL Server running on a virtual server on Microsoft Cluster Service, it returns the name of the virtual server. NULL = Input is not valid, an error, or not applicable.");
        public Pair ProcessID = new Pair("ProcessID", "", "Process ID of the SQL Server service. ProcessID is useful in identifying which Sqlservr.exe belongs to this instance.");
        public Pair ProductBuild = new Pair("ProductBuild", "", "The build number. Applies to: SQL Server 2014 beginning October, 2015.");
        public Pair ProductBuildType = new Pair("ProductBuildType", "", "Type of build of the current build. OD = On Demand release a specific customer. GDR = General Distribution Release released through windows update. NULL = Not applicable.");
        public Pair ProductLevel = new Pair("ProductLevel", "", "Level of the version of the instance of SQL Server. RTM = Original release version. SPn = Service pack version. CTPn = Community Technology Preview version");
        public Pair ProductMajorVersion = new Pair("ProductMajorVersion", "", "The major version. Applies to: SQL Server 2014 beginning October, 2015.");
        public Pair ProductMinorVersion = new Pair("ProductMinorVersion", "", "The minor version. Applies to: SQL Server 2014 beginning October, 2015.");
        public Pair ProductUpdateLevel = new Pair("ProductUpdateLevel", "", "Update level of the current build. CU indicates a cumulative update. CUn = Cumulative Update. NULL = Not applicable.");
        public Pair ProductUpdateReference = new Pair("ProductUpdateReference", "", "KB article for that release. Applies to: SQL Server 2014 beginning October, 2015.");
        public Pair ProductVersion = new Pair("ProductVersion", "", "Version of the instance of SQL Server, in the form of /major.minor.build.revision/.");
        public Pair ResourceLastUpdateDateTime = new Pair("ResourceLastUpdateDateTime", "", "The date and time that the Resource database was last updated.");
        public Pair ResourceVersion = new Pair("ResourceVersion", "", "The resource database version.");
        public Pair ServerName = new Pair("ServerName", "", @"Both the Windows server and instance information associated with a specified instance of SQL Server. \n Server NameDefault instance ‘servername’ / Named instance ‘servername\instancename’ / failover clustered instance – default instance ‘virtualservername’ / failover clustered instance – named instance ‘virtualservername\instancename’");
        public Pair SqlCharSet = new Pair("SqlCharSet", "", "The SQL character set ID from the collation ID.");
        public Pair SqlCharSetName = new Pair("SqlCharSetName", "", "The SQL character set name from the collation.");
        public Pair SqlSortOrder = new Pair("SqlSortOrder", "", "The SQL sort order ID from the collation");
        public Pair SqlSortOrderName = new Pair("SqlSortOrderName", "", "The SQL sort order name from the collation.");
        public Pair CONNECTIONS = new Pair("CONNECTIONS", "", "The number of logins or attempted logins since SQL Server was last started");
        public Pair CPU_Busy = new Pair("CPU Busy", "", "The Number of seconds CPU has spent Working since SQL Server was last started");
        public Pair CursorRows = new Pair("Cursor Rows", "", "Number of rows currently in the last opened cursor (for the current connection)");
        public Pair DateFirst = new Pair("Date First", "", "First day of the week. 1 for Monday, 2 for Tuesday, etc. Default is 7(Sunday).");
        public Pair DBTimeStamp = new Pair("DB Time Stamp", "", "The last-used timestamp value of the current database. A new timestamp value is generated when a row with a timestamp column is inserted or updated.timestamp is guaranteed to be unique in the database.");
        public Pair DefaultLangID = new Pair("Default Lang ID", "", "");
        public Pair Identity = new Pair("Identity", "", "Returns the last IDENTITY value inserted. If there havent been any IDENTITY values inserted than this variable is NULL.");
        public Pair Iddle = new Pair("Iddle", "", "Number of milliseconds SQL Server has been idle since it was last started");
        public Pair IOBusy = new Pair("I/O Busy", "",  "The amount of time, in ticks, that SQL Server has spent doing input and output operations    since it was last started. i.e Number of milliseconds SQL Server has spent performing Input and Output (IO) operations since it was last started");
        public Pair LangID = new Pair("Lang ID", "", "Language ID");
        public Pair LanguageName = new Pair("Language Name", "", "Language Name");
        public Pair LockTimeOut = new Pair("Lock TimeOut", "", @"current lock time-out setting in milliseconds for the current session.SET LOCK_TIMEOUT allows an application to set the maximum time that a statement waits on a blocked resource. When a statement has waited longer than the LOCK_TIMEOUT setting, the blocked statement is automatically canceled, and an error message is returned to the application.");
        public Pair MaxConnection = new Pair("Max Connection", "", "max # connections allowed simultaneously to server");
        public Pair Maxprecision = new Pair("Max precision", "", "Max Precision");
        public Pair MSVersionCode = new Pair("MS Version code", "", "SQL Server version Hex Code.");
        public Pair NestingSpLevel = new Pair("Nesting sp level", "", "Returns the nesting level of the current stored procedure execution (initially 0) on the local server. Each time a stored procedure calls another stored procedure or executes managed code by referencing a common language runtime (CLR) routine, type, or aggregate, the nesting level is incremented. When the maximum of 32 is exceeded, the transaction is terminated. When @@NESTLEVEL is executed within a Transact-SQL string, the value returned is 1 + the current nesting level. When @@NESTLEVEL is executed dynamically by using sp_executesql the value returned is 2 + the current nesting level.");
        public Pair Options = new Pair("Options", "", "Returns information about the current SET options (max 15). The @@OPTIONS function returns a bitmap of the options, converted to a base 10 (decimal) integer. The bit settings are stored in the locations described in the topic Configure the user options Server Configuration Option. To decode the @@OPTIONS value, convert the integer returned by @@OPTIONS to binary, and then look up the values on the table above.");
        public Pair PacketRecieved = new Pair("Packet recieved", "", "A number of input packets read from the network by SQL Server since it was last started");
        public Pair PacketSent = new Pair("Packet sent", "", "A number of output packets written to the network by SQL Server since it was last started");
        public Pair PacketErrors = new Pair("Packet Errors", "", "A number of network packet errors that have occurred on SQL Server connections since SQL Server was last started");
        public Pair RemoteSQLServer = new Pair("Remote SQL Server", "", "Remote SQL Server, it being deprecated.");
        public Pair RowCount = new Pair("Row Count", "", "A number of rows affected by the last statement");
        public Pair ServiceName = new Pair("Service Name", "", "Service Name. ServiceName,–CURRENT INSTANCE DEFAULT/INSTANCE NAME");
        public Pair MaxTextSize = new Pair("Max Text Size", "", "Text Size Specifies the size of varchar(max), nvarchar(max), varbinary(max), text, ntext, and image data returned by a SELECT statement.");
        public Pair TimeTicks = new Pair("Time Ticks", "", "Time Ticks. Returns the number of microseconds per tick. The amount of time per tick is computer-dependent. Each tick on the operating system is 31.25 milliseconds, or one thirty-second of a second.");
        public Pair TotalErrors = new Pair("Total Errors", "", "Returns the number of disk write errors encountered by SQL Server since SQL Server last started. Not all write errors encountered by SQL Server are accounted for by this function. Occasional non-fatal write errors are handled by the server itself and are not considered errors. To display a report containing several SQL Server statistics, including total number of errors, run sp_monitor.");
        public Pair TotalReads = new Pair("Total Reads", "", "A number of disk reads, not cache reads, by SQL Server since SQL Server was last started");
        public Pair TotalWrites = new Pair("Total Writes", "", "A number of disk writes by SQL Server since SQL Server was last started");
        public Pair TransactionNumbers = new Pair("Transaction numbers", "", "A number of active transactions for the current connection");
        public Pair SQLServerVersion = new Pair("SQL Server Version", "", "Returns system and build information for the current installation of SQL Server.");

    }
}
