--CREATE DATABASE TicketDB;
--USE TicketDB;

----Drop Table Ticket;
--CREATE TABLE Ticket(
--ID INT Identity(1,1) NOT NULL Primary Key,
--DateSubmitted DATE,
--DateCompleted DATE,
--SubjectBrief NVARCHAR(100),
--FullIssue NVARCHAR (700),
--[Open] BIT,
--);

--CREATE TABLE Favorites(
--	ID INT Identity(1,1) NOT NULL Primary Key,
--	[UID] NVARCHAR(20) NOT NULL,
--	DateAdded DATE,
--	TicketId INT FOREIGN KEY REFERENCES Ticket(ID),
--	);