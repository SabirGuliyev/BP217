

CREATE DATABASE BP217

USE BP217

DROP TABLE Students
CREATE TABLE Students(

Id INT,
[Name] NVARCHAR(25),
Surname NVARCHAR(25),
Age INT
)

ALTER TABLE Students ADD Email VARCHAR(256), FinCode CHAR(7)
ALTER TABLE Students DROP COLUMN FinCode



INSERT INTO 
Students 
VALUES
(1,'Mehin',N'Rəhimli',20,'mehin@code.edu.az'),
(2,'Kobra',N'Əhmədova',20,'kobra@code.edu.az'),
(3,'Ayxan',N'Mammadli',20,'ayxan@code.edu.az'),
(4,'Azad',N'Ashurov',20,'mehin@code.edu.az')

INSERT INTO Students(Email,Age,Id) VALUES('salam@code.edu.az',23,7) 

UPDATE Students SET Name='Allahverdi',Surname='Sultanov' WHERE Id=1

DELETE FROM Students



SELECT * FROM Students

SELECT Name+' '+ Surname AS Fullname FROM Students WHERE Name like '%a_'