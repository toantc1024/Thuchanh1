--CREATE DATABASE SchoolManagementDB;
--USE SchoolManagementDB;
--GO;

DROP TABLE Student;
IF OBJECT_ID(N'dbo.Student', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Student];  
GO


CREATE TABLE Student (
	ID int IDENTITY(1,1) PRIMARY KEY,
	fullName varchar(100),
	address varchar(255),
	governmentId varchar(100) unique not null,
	dateOfBirth DateTime,
	phoneNumber varchar(20),
	email varchar(30),
	sex varchar(10),
);
select * from Student;

IF OBJECT_ID(N'dbo.Teacher', N'U') IS NOT NULL  
   DROP TABLE [dbo].[Teacher];  
GO
CREATE TABLE Teacher (
	ID int IDENTITY(1,1) PRIMARY KEY,
	fullName varchar(100),
	address varchar(255),
	governmentId varchar(100) unique not null,
	dateOfBirth DateTime,
	phoneNumber varchar(20),
	email varchar(30),
	sex varchar(10),
);
select * from Teacher;