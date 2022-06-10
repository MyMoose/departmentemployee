ALTER PROC dbo.Employee_Delete
			@EmployeeId int

/*---------------TEST--------------------

Declare @EmployeeId int = 2

Select *
from dbo.Employee
Where EmployeeId = @EmployeeId

Execute dbo.Employee_Delete @EmployeeId

Select *
from dbo.Employee
Where EmployeeId = @EmployeeId

*/

as


BEGIN


Delete from dbo.Employee
Where EmployeeId = @EmployeeId


END