SELECT *
FROM master.dbo.sysdatabases


name			dbid	sid								mode	status	status2	crdate	reserved		category				cmptlevel	filename											version
master			1	0x01								0	65544	1090520064	2003-04-08 09:13:36.390	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\master.mdf		661
tempdb			2	0x01								0	65544	1090520064	2015-05-01 02:00:52.883	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\tempdb.mdf		661
model			3	0x01								0	65536	1090519040	2003-04-08 09:13:36.390	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\model.mdf		661
msdb			4	0x01								0	65544	1627390976	2010-04-02 17:35:08.970	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\MSDBData.mdf		661
ReportServer		5	0x0105000000000005150000009C93382A426FF447CAADBA9CF4010000	0	65536	1627389952	2014-09-29 23:45:55.450	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\ReportServer.mdf	661
ReportServerTempDB	6	0x0105000000000005150000009C93382A426FF447CAADBA9CF4010000	0	65544	1627389952	2014-09-29 23:45:55.627	1900-01-01 00:00:00.000	0		100		C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\ReportServerTempDB.mdf	661
NissanILS		7	0x01								0	24	1090519040	2014-10-09 19:32:37.410	1900-01-01 00:00:00.000	0		80		E:\MSSQL\Data\NissanILS.MDF									661
BatchProc_TempDB	8	0x813CB68F3B8DA94894590506ECED53D7				0	24	1090519040	2014-12-15 17:19:15.110	1900-01-01 00:00:00.000	0		80		E:\MSSQL\DATA\BatchProc_TempDB.mdf								661
NissanNNA		9	0x01								0	24	1090519040	2015-09-09 06:10:48.050	1900-01-01 00:00:00.000	0		80		E:\MSSQL\Data\NissanNNA_system.mdf								661
Nissan_reports		10	0x01								0	24	1073741824	2014-10-15 16:06:34.383	1900-01-01 00:00:00.000	0		80		E:\MSSQL\Data\NISSAN_REPORTS.MDF								661
NissanDLS		11	0xEFF9BCFB3A339E47877280FDA2EF44E8				0	65536	1627389952	2015-07-14 04:29:27.327	1900-01-01 00:00:00.000	0		100		E:\MSSQL\Data\NissanDLS.mdf									661



SELECT 
name AS FileName, 
size*1.0/128 AS FileSizeinMB,
'MaximumSizeinMB' = 
    CASE max_size 
       WHEN 0 THEN 'No growth is allowed.'
       WHEN -1 THEN 'Autogrowth is on.'
       WHEN 268435456 
          THEN 'Log file will grow to a maximum size of 2 TB.'
       ELSE CAST (max_size*1.0/128 AS nvarchar(30))
    END,
growth AS 'GrowthValue',
'GrowthIncrement' = 
    CASE 
       WHEN growth = 0 THEN 'File size is fixed and will not grow.'
       WHEN growth > 0 AND is_percent_growth = 0 
          THEN 'Growth value is in units of 8-KB pages.'
       ELSE 'Growth value is a percentage.'
    END
FROM tempdb.sys.database_files;
GO
USE tempdb;
GO
SELECT (SUM(unallocated_extent_page_count)*1.0/128) AS free_space_in_MB,
(SUM(version_store_reserved_page_count + 
    user_object_reserved_page_count +internal_object_reserved_page_count + 
    mixed_extent_page_count)*1.0/128) AS used_space_in_MB
FROM sys.dm_db_file_space_usage;
