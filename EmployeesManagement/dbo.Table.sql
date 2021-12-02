CREATE TABLE [dbo].[EmployeeTbl]
(
	[EmpID] VARCHAR(10) NOT NULL PRIMARY KEY, 
    [EmpName] VARCHAR(50) NOT NULL, 
    [EmpGender] VARCHAR(10) NOT NULL, 
    [EmpPosition] VARCHAR(50) NOT NULL, 
    [EmpDOB] VARCHAR(50) NOT NULL, 
    [EmpPhone] VARCHAR(10) NOT NULL, 
    [EmpAddress] VARCHAR(50) NOT NULL, 
    [EmpEducation] VARCHAR(50) NOT NULL
)
