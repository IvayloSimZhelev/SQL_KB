select name, definition, type_desc FROM sys.sql_modules m 
INNER JOIN sys.objects o ON m.object_id=o.object_id
where type_desc like '%function%';