USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Employee_Insert]    Script Date: 6/9/2022 12:43:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Employee_Insert]
			@EmployeeName nvarchar(500)
			,@Department nvarchar(500)			
			,@PhotoFileName nvarchar(500)
			,@EmployeeId int OUTPUT

/*-----------------TEST-----------------------

Declare @EmployeeId int = 0;

Declare @EmployeeName nvarchar(500)		= 'John'
		,@Department nvarchar(500)		= 'IT'		
		,@PhotoFileName nvarchar(500)	= 'anonymous.png'

EXECUTE dbo.Employee_Insert			@EmployeeName
									,@Department									
									,@PhotoFileName
									,@EmployeeId OUTPUT

Select *
from dbo.Employee


*/

as

BEGIN


INSERT INTO [dbo].[Employee]
           ([EmployeeName]
           ,[Department]           
           ,[PhotoFileName])

VALUES     (@EmployeeName
           ,@Department           
           ,@PhotoFileName)

SET @EmployeeId = SCOPE_IDENTITY()

END