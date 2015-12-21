select *
from 
    sys.objects             O LEFT OUTER JOIN
    sys.extended_properties E ON O.object_id = E.major_id
WHERE
    O.name IS NOT NULL
    AND ISNULL(O.is_ms_shipped, 0) = 0
    AND ISNULL(E.name, '') <> 'microsoft_database_tools_support'
    AND O.type_desc = 'SQL_STORED_PROCEDURE'
ORDER BY O.name

select *
from 
    sys.objects             O LEFT OUTER JOIN
    sys.extended_properties E ON O.object_id = E.major_id
WHERE
    O.name IS NOT NULL
    AND ISNULL(O.is_ms_shipped, 0) = 0
    AND ISNULL(E.name, '') <> 'microsoft_database_tools_support'
    AND O.type_desc = 'SQL_TRIGGER'
ORDER BY O.name


is_ms_shipped = 0 to exclude system table and sp and other object
SELECT top 1
    pr.name,
    m.definition,
    pr.type_desc,
    pr.create_date,
    pr.modify_date 
FROM 
    sys.procedures pr
INNER JOIN 
    sys.sql_modules m ON pr.object_id = m.object_id
WHERE 
    is_ms_shipped = 0
ORDER BY 
    pr.Name

sys.procedures.name	
sys.procedures.object_id	
sys.procedures.principal_id	
sys.procedures.schema_id	
sys.procedures.parent_object_id	
sys.procedures.type	
sys.procedures.type_desc	
sys.procedures.create_date	
sys.procedures.modify_date	
sys.procedures.is_ms_shipped	
sys.procedures.is_published	
sys.procedures.is_schema_published	
sys.procedures.is_auto_executed	
sys.procedures.is_execution_replicated	
sys.procedures.is_repl_serializable_only	
sys.procedures.skips_repl_constraints

sys.sql_modules.object_id
sys.sql_modules.definition
sys.sql_modules.uses_ansi_nulls
sys.sql_modules.uses_quoted_identifier	
sys.sql_modules.is_schema_bound	
sys.sql_modules.sys.sql_modules.uses_database_collation	
sys.sql_modules.is_recompiled	
sys.sql_modules.null_on_null_input	
sys.sql_modules.execute_as_principal_id



