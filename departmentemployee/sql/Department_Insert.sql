USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Department_Insert]    Script Date: 6/9/2022 5:02:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Department_Insert]
			@DepartmentName nvarchar(500)
			,@DepartmentId int OUTPUT

/*-----------------TEST---------------------

Declare @DepartmentId int = 0;

Declare @DepartmentName nvarchar(500) = 'IT'

Execute dbo.Department_Insert		@DepartmentName
									,@DepartmentId OUTPUT

Select *
from dbo.Department

*/
as


BEGIN



INSERT INTO [dbo].[Department]
           ([DepartmentName])

VALUES (@DepartmentName)

SET @DepartmentId = SCOPE_IDENTITY()


END