CREATE TABLE [dbo].[tblUserMaster]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1) , 
    [Username] VARCHAR(200) NOT NULL,
	[Password] VARCHAR(500) Not Null, 
    [Name] VARCHAR(250) NULL, 
    [Gender] VARCHAR(50) NULL, 
    [DateofBirth] DATETIME NULL,
)
