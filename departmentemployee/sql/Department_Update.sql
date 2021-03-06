USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Department_Update]    Script Date: 6/9/2022 12:43:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Department_Update]
			@DepartmentName nvarchar(500)
			,@DepartmentId int

/*---------------------TEST------------------------

Declare @DepartmentId int = 1

Declare @DepartmentName nvarchar(500) = 'IT Updated'

Select *
from dbo.Department
Where DepartmentId = @DepartmentId

Execute dbo.Department_Update		@DepartmentName
									,@DepartmentId

Select *
from dbo.Department
Where DepartmentId = @DepartmentId


*/

as

BEGIN

Update dbo.Department
SET [DepartmentName] = @DepartmentName
WHERE DepartmentId = @DepartmentId

END