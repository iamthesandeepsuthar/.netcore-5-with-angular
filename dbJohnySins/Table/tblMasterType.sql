CREATE TABLE [dbo].[tblMasterType]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1), 
    [Name] VARCHAR(100) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [IsDelete] BIT NOT NULL DEFAULT 0, 
    [Description] VARCHAR(1000) NULL
)
