select *from tblSubject
select *from tblLevel

INSERT INTO tblLevel VALUES('IX')
INSERT INTO tblLevel VALUES('X')
INSERT INTO tblLevel VALUES('XI')

INSERT INTO tblSubject VALUES('Matem�ticas',4,1)
INSERT INTO tblSubject VALUES('Lenguaje',3,1)
INSERT INTO tblSubject VALUES('Filosofia',3,1)

INSERT INTO tblSubject VALUES('C�lculo',3,2)
INSERT INTO tblSubject VALUES('F�sica',5,2)
INSERT INTO tblSubject VALUES('Qu�mica',2,2)

INSERT INTO tblSubject VALUES('M�todos Num�ricos',3,3)
INSERT INTO tblSubject VALUES('Probabilidad',3,3)
INSERT INTO tblSubject VALUES('Sistemas',4,3)

--Obtener el curso y y las materias
SELECT Stage,Description,Credits from tblLevel 
JOIN tblSubject ON tblLevel.Id_Level=tblSubject.Level_Id_Level

select *from tblSubject 
select *from tblTeacher
select *from TeacherSubjects

INSERT INTO TeacherSubjects VALUES('123456',5)
INSERT INTO TeacherSubjects VALUES('123456',7)

INSERT INTO TeacherSubjects VALUES('68840',1)
INSERT INTO TeacherSubjects VALUES('68840',8)

DELETE FROM TeacherSubjects where Teacher_DNI='68840'