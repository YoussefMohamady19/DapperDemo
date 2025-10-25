Create Database DapperDemoDB;
GO

USE DapperDemoDB;
GO

Create table Students(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100),
	Age INT,
	Email NVARCHAR(100)

);
