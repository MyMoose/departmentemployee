USE [Angular12]
GO
/****** Object:  StoredProcedure [dbo].[Department_SelectAll]    Script Date: 6/9/2022 12:43:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Department_SelectAll]

/*--------------------TEST------------------


Execute dbo.Department_SelectAll

*/
as

BEGIN


Select DepartmentId
		,DepartmentName
		,TotalCount = COUNT(1) OVER()

FROM dbo.Department

END