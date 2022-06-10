USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Employee_SelectAll]    Script Date: 6/9/2022 12:43:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Employee_SelectAll]

/*--------------------TEST------------------


Execute dbo.Employee_SelectAll

*/
as

BEGIN


Select EmployeeId
		,EmployeeName
		,Department
		,DateOfJoining
		,PhotoFileName
		,TotalCount = COUNT(1) OVER()

FROM dbo.Employee

END