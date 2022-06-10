USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Department_Delete]    Script Date: 6/9/2022 12:43:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Department_Delete]
			@DepartmentId int

/*-------------------TEST-----------------------

Declare @DepartmentId int = 2;

Select * 
from dbo.Department
Where DepartmentId = @DepartmentId

Execute dbo.Department_Delete @DepartmentId

Select * 
from dbo.Department
Where DepartmentId = @DepartmentId


*/
as


BEGIN

Delete from dbo.Department
Where DepartmentId = @DepartmentId

END