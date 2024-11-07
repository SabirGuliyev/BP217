CREATE DATABASE ExceptExample

USE ExceptExample




CREATE TABLE Products(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(200) UNIQUE NOT NULL,
Price DECIMAL(6,2) NOT NULL
)

CREATE TABLE Sizes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(80) UNIQUE NOT NULL
)

CREATE TABLE ProductSizes(
Id INT PRIMARY KEY IDENTITY,
ProductId INT REFERENCES Products(Id),
SizeId INT REFERENCES Sizes(Id),
)



SELECT p.Id, p.Name,Len(s.Name) Size FROM Products AS p
JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id
--GROUP BY p.Name, p.Id


SELECT  p.Name,COUNT(s.Name) Size FROM Products AS p
JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id
WHERE p.Price>100
GROUP BY p.Name
HAVING COUNT(s.Name)>3



--SELECT p.Name, s.Name AS Size FROM Products AS p
--CROSS JOIN Sizes AS s
--WHERE p.Price BETWEEN 40 AND 300



--CREATE TABLE Students(
--Id INT PRIMARY KEY IDENTITY,
--Name NVARCHAR(50) NOT NULL,
--Point INT CHECK(Point BETWEEN 0 AND 100)
--)

--CREATE TABLE Grades(
--Id INT PRIMARY KEY IDENTITY,
--Letter CHAR(1) UNIQUE NOT NULL,
--MinGrade INT CHECK(MinGrade BETWEEN 0 AND 91 ),
--MaxGrade INT CHECK(MaxGrade BETWEEN 50 AND 100 )

--)


--non-equi join
SELECT s.Name,g.Letter AS Grade FROM Students AS s
JOIN Grades AS g
ON Point BETWEEN g.MinGrade AND g.MaxGrade



CREATE TABLE KHProducts(

Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(200) UNIQUE NOT NULL,
Price DECIMAL(6,2) NOT NULL
)


CREATE TABLE IrshadProducts(

Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(200) UNIQUE NOT NULL,
Price DECIMAL(6,2) NOT NULL
)



SELECT Name FROM KHProducts
UNION
SELECT Name FROM IrshadProducts


SELECT Name FROM KHProducts
INTERSECT
SELECT Name FROM IrshadProducts



SELECT Name FROM IrshadProducts
EXCEPT
SELECT Name FROM KHProducts






SELECT  p.Name,s.Name Size FROM Products AS p
JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id



SELECT  p.Name,s.Name Size FROM Products AS p
JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id
WHERE p.Price IN (100,150,200)



CREATE VIEW GetProductSizes
AS
SELECT p.Price, p.Name AS [ProductIdentity],s.Name Size FROM Products AS p
JOIN ProductSizes AS ps
ON p.Id=ps.ProductId
JOIN Sizes AS s
ON ps.SizeId=s.Id



SELECT ProductIdentity,Size FROM GetProductSizes WHERE Price>100



CREATE VIEW GetStudentGrades
AS
SELECT s.Name,g.Letter AS Grade, s.Point FROM Students AS s
JOIN Grades AS g
ON Point BETWEEN g.MinGrade AND g.MaxGrade




SELECT * FROM (SELECT s.Name,g.Letter AS Grade, s.Point FROM Students AS s
JOIN Grades AS g
ON Point BETWEEN g.MinGrade AND g.MaxGrade) AS Gr
WHERE Point=
(SELECT MIN(Point) AS Point FROM 
(SELECT Name, Grade,Point FROM (SELECT s.Name,g.Letter AS Grade, s.Point FROM Students AS s
JOIN Grades AS g
ON Point BETWEEN g.MinGrade AND g.MaxGrade) as Gr
WHERE Point BETWEEN 51 AND 100) AS sub)




SELECT * FROM GetStudentGrades 
WHERE Point=
(SELECT MIN(Point) AS Point FROM 
(SELECT Name, Grade,Point FROM GetStudentGrades
WHERE Point BETWEEN 51 AND 100) AS sub)


SELECT * FROM GetStudentGrades
ORDER BY Name


--TRUNCATE TABLE KHProducts



SELECT * FROM GetStudentGrades
WHERE Point>80

SELECT * FROM GetStudentGrades
WHERE Point>90

SELECT * FROM GetStudentGrades
WHERE Point>50


CREATE PROCEDURE usp_GetStudentsByPoint @point INT
AS
SELECT * FROM GetStudentGrades
WHERE Point>@point


EXEC usp_GetStudentsByPoint 50

EXEC usp_GetStudentsByPoint 80

CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(1) UNIQUE NOT NULL,
MinGrade INT CHECK(MinGrade BETWEEN 0 AND 91 ),
MaxGrade INT CHECK(MaxGrade BETWEEN 50 AND 100 )

)


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
Point INT CHECK(Point BETWEEN 0 AND 100)
)

ALTER TABLE Students ADD Surname NVARCHAR(25) DEFAULT 'XXX'

CREATE PROCEDURE usp_CreateStudent (@name NVARCHAR(50),@point INT, @surname NVARCHAR(25)='XXX')
AS
SET @name=(SELECT  dbo.Capitalize(@name))
SET @surname=(SELECT  dbo.Capitalize(@surname))
INSERT INTO Students VALUES(@name,@point,@surname)

EXEC usp_CreateStudent 'mirDAvUd',95,'meHdiYEV'



ALTER FUNCTION Capitalize(@word NVARCHAR(100))
RETURNS NVARCHAR(100)
AS
BEGIN
SET @word=UPPER(LEFT(@word,1))+LOWER(SUBSTRING(@word,2,LEN(@word)))
RETURN @word
END



EXEC usp_CreateStudent 'iSi',94,'isiYEV'




