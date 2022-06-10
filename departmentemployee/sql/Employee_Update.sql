ALTER PROC dbo.Employee_Update
			@EmployeeName nvarchar(500)
			,@Department nvarchar(500)			
			,@PhotoFileName nvarchar(500)
			,@EmployeeId int 

/*------------------TEST-----------------

Declare @EmployeeId int = 1

Declare @EmployeeName nvarchar(500) = 'Bob Update'
		,@Department nvarchar(500) = 'IT'
		,@PhotoFileName nvarchar(500) = 'anonymous.png'

Select *
from dbo.Employee
Where EmployeeId = @EmployeeId

Execute dbo.Employee_Update		@EmployeeName
								,@Department
								,@PhotoFileName
								,@EmployeeId

Select *
from dbo.Employee
Where EmployeeId = @EmployeeId

*/
as

BEGIN

UPDATE dbo.Employee

SET [EmployeeName] = @EmployeeName
      ,[Department] = @Department      
      ,[PhotoFileName] = @PhotoFileName

WHERE EmployeeId = @EmployeeId


END