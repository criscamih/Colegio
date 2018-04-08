select *from tblSubject
select *from tblLevel

INSERT INTO tblLevel VALUES('IX')
INSERT INTO tblLevel VALUES('X')
INSERT INTO tblLevel VALUES('XI')

INSERT INTO tblSubject VALUES('Matemáticas',4,1)
INSERT INTO tblSubject VALUES('Lenguaje',3,1)
INSERT INTO tblSubject VALUES('Filosofia',3,1)

INSERT INTO tblSubject VALUES('Cálculo',3,2)
INSERT INTO tblSubject VALUES('Física',5,2)
INSERT INTO tblSubject VALUES('Química',2,2)

INSERT INTO tblSubject VALUES('Métodos Numéricos',3,3)
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

INSERT INTO tblStudent(DNI,NameStudent,DateInput) VALUES('80123456','Abbie Cornish','2015-2-1')
INSERT INTO tblStudent(DNI,NameStudent,DateInput) VALUES('456132','Homero','2016-2-1')
INSERT INTO tblStudent(DNI,NameStudent,DateInput) VALUES('741852','Barto','2016-6-15')
INSERT INTO tblStudent(DNI,NameStudent,DateInput) VALUES('966385','Judd','2017-2-1')
INSERT INTO tblStudent(DNI,NameStudent,DateInput) VALUES('852963','Lisa','2015-6-15')

select *from tblStudent
select *from tblSubject 
select *from tblLevel
select *from tblScores

