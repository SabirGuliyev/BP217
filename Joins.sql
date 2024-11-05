--CREATE DATABASE ConstraintDB

--USE  ConstraintDB


--CREATE TABLE Students(
--Id INT PRIMARY KEY IDENTITY,
--[Name] NVARCHAR(25) NOT NULL,
--Surname NVARCHAR(25) DEFAULT 'XXX',
--Age INT CHECK(Age>10 AND Age<60),
--Email VARCHAR(256) UNIQUE
--)


--INSERT INTO Students(Name,Age,Email) VALUES('Azad',20,'azad@')

CREATE DATABASE RelationExample

USE  RelationExample



CREATE TABLE Universities(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(200) UNIQUE NOT NULL
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(25) NOT NULL,
UnversityId INT REFERENCES Universities(Id)
)


SELECT s.Name,u.Name as University FROM Students AS s
FULL OUTER JOIN Universities as u
ON s.UnversityId=u.Id
WHERE s.UnversityId IS NULL



CREATE TABLE Positions(

Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(200) UNIQUE NOT NULL,
DependId INT REFERENCES Positions(Id)
)


SELECT p.Name, d.Name as Depend FROM Positions AS p
LEFT JOIN Positions AS d
ON p.DependId=d.Id


