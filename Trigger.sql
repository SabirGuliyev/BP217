
CREATE DATABASE TriggerExample

USE TriggerExample


CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
Age INT CHECK(Age BETWEEN 10 AND 65),
IsDeleted BIT
)

ALTER TABLE Students ADD IsDeleted BIT


INSERT INTO Students VALUES
('meHin','rahiMlI',20),
('Ayla','Atakishiyeva',19),
('Kobra','Ahmadova',19),
('Azad','Ashurov',19),
('Ismayil','Ibrahimzade',19)

--CREATE TRIGGER GetStudentsAfterDelete
--ON Students
--AFTER DELETE
--AS
--BEGIN

--SELECT * FROM Students

--END

--ALTER TRIGGER GetStudentsAfterDelete
--ON Students
--AFTER DELETE
--AS
--BEGIN

--SELECT * FROM DELETED

--END


--DROP TRIGGER GetStudentsAfterDelete


CREATE FUNCTION Capitalize(@name NVARCHAR(25))
RETURNS NVARCHAR(25)
AS
BEGIN
 
 SET @name=UPPER(LEFT(@name,1))+LOWER(SUBSTRING(@name,2,LEN(@name)-1))

 RETURN @name

END


CREATE TRIGGER CapitalizeCreatedStudent
ON Students
INSTEAD OF INSERT
AS
BEGIN

DECLARE @name NVARCHAR(25)
DECLARE @surname NVARCHAR(25)

SELECT @name=Name,@surname=Surname FROM INSERTED


SET @name=(SELECT  dbo.Capitalize(@name))
SET @surname=(SELECT  dbo.Capitalize(@surname))

INSERT INTO Students VALUES(@name,@surname,(SELECT Age FROM INSERTED))
END






DELETE FROM Students WHERE Id=6


--UPDATE Students SET Name='Mehin2' WHERE Id=1







INSERT INTO Students VALUES('tesT','teSTOV',30)




CREATE TRIGGER SoftDelete
ON Students
INSTEAD OF DELETE
AS
BEGIN

DECLARE @isDeleted BIT
DECLARE @id INT

SELECT @isDeleted=IsDeleted,@id=Id FROM DELETED

IF(@isDeleted=0)
 BEGIN
 UPDATE Students SET IsDeleted=1 WHERE Id=@id
 END
ELSE
 BEGIN
 DELETE FROM Students WHERE Id=@id
 END

END




DELETE FROM Students WHERE Id=7


SELECT * FROM Students WHERE IsDeleted=0