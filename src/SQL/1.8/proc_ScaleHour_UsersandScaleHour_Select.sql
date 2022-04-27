﻿USE TritonFleetManagement
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_ScaleHour_UsersandScaleHour_Select]')
AND type in (N'P', N'PC'))

PRINT 'YES'
GO 


CREATE PROC [dbo].[proc_ScaleHour_UsersandScaleHour_Select]
AS 
BEGIN
	SELECT 
	SC.ScaleHourID,
	E.employeeID EmployeeID, 
	CONCAT(E.FullNames,' ',E.Surname) EmployeeName,
	SC.CostScaleHour,
	SC.CreatedOn,
	SC.CreatedByUserID,
	U.Name CreatedBy,
	SC.DeletedOn,
	SC.DeletedByUserID
	FROM leavemanagement.dbo.Employees E
	INNER JOIN TritonFleetManagement.dbo.ScaleHours SC ON SC.EmployeeID = E.EmployeeID
	INNER JOIN TritonSecurity.dbo.Users U ON U.UserID = SC.CreatedByUserID
END