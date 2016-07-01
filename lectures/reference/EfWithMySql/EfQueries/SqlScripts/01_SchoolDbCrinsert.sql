drop database if exists SchoolDb;

create database SchoolDb;
use SchoolDb;


CREATE TABLE `Course`(
	`CourseId` int AUTO_INCREMENT NOT NULL,
	`CourseName` varchar(50) NOT NULL,
	`TeacherId` int NULL,
 CONSTRAINT `PK_Course_1` PRIMARY KEY 
(
	`CourseId` ASC
)
);


CREATE TABLE `Standard`(
	`StandardId` int AUTO_INCREMENT NOT NULL,
	`StandardName` varchar(50) NOT NULL,
	`Description` varchar(50) NULL,
 CONSTRAINT `PK_Standard` PRIMARY KEY 
(
	`StandardId` ASC
)
);



CREATE TABLE Student(
	`StudentID` int AUTO_INCREMENT NOT NULL,
	`StudentName` varchar(50) NULL,
	`StandardId` int NULL,
	`RowVersion` timestamp NOT NULL,
 CONSTRAINT `PK_Student` PRIMARY KEY 
(
	`StudentID` ASC
) 
);

CREATE TABLE StudentAddress(
	`StudentID` int NOT NULL,
	`Address1` varchar(50) NOT NULL,
	`Address2` varchar(50) NULL,
	`City` varchar(50) NOT NULL,
	`State` varchar(50) NOT NULL,
 CONSTRAINT `PK_StudentAddress` PRIMARY KEY 
(
	`StudentID` ASC
) 
);


CREATE TABLE StudentCourse(
	`StudentId` int NOT NULL,
	`CourseId` int NOT NULL,
 CONSTRAINT `PK_StudentCourse` PRIMARY KEY 
(
	`StudentId` ASC,
	`CourseId` ASC
) 
);


CREATE TABLE Teacher(
	`TeacherId` int AUTO_INCREMENT NOT NULL,
	`TeacherName` varchar(50) NULL,
	`StandardId` int NULL,
 CONSTRAINT `PK_Teacher_1` PRIMARY KEY 
(
	`TeacherId` ASC
) 
);

INSERT Course (`CourseId`, `CourseName`, `TeacherId`) values 
(1, 'Maths', 1)
, (2, 'Science', 2)
, (3, 'History', 3)
, (4, 'English', 4)
, (5, 'Spanish', 5);



INSERT Standard (`StandardId`, `StandardName`, `Description`) values 
(1, 'Standard1', 'Standard 1Grade1')
, (2, 'Standard2', NULL)
, (3, 'Standard3', NULL)
, (4, 'Standard4', NULL)
, (5, 'Standard5', NULL);


INSERT Student (`StudentID`, `StudentName`, `StandardId`) VALUES 
(1, 'Student1', 1)
, (2, 'Student2', NULL)
, (3, 'Student3', NULL)
, (4, 'Student4', NULL)
, (5, 'Student5', NULL)
, (6, 'Student6', NULL)
, (7, 'Student7', NULL)
, (8, 'Student8', NULL)
, (9, 'Student9', NULL)
, (10, 'Student10', NULL);


INSERT StudentAddress (`StudentID`, `Address1`, `Address2`, `City`, `State`) VALUES 
(1, 'Student1Address1', 'Student1Address2', 'Student1City', 'Student1State')
, (2, 'Student2Address1', 'Student2Address2', 'Student2City', 'Student2State')
, (3, 'Student3Address1', 'Student3Address2', 'Student3City', 'Student3State');

INSERT StudentCourse (`StudentId`, `CourseId`) VALUES 
(1, 3)
, (1, 4)
, (1, 5)
, (2, 3)
, (2, 4)
, (2, 5)
, (3, 4)
, (4, 1)
, (4, 2)
, (5, 4);


INSERT Teacher (`TeacherId`, `TeacherName`, `StandardId`) VALUES 
(1, 'Teacher2', 1)
, (2, 'Teacher2', 2)
, (3, 'Teacher3', 3)
, (4, 'Teacher4', 4)
, (5, 'Teacher5', 5)
, (7, 'Teacher7', 1);


ALTER TABLE `Course` ADD  CONSTRAINT `FK_Course_Teacher` FOREIGN KEY(`TeacherId`)
REFERENCES `Teacher` (`TeacherId`);

ALTER TABLE `Student` ADD CONSTRAINT `FK_Student_Standard` FOREIGN KEY(`StandardId`)
REFERENCES `Standard` (`StandardId`);

ALTER TABLE `StudentAddress` ADD CONSTRAINT `FK_StudentAddress_Student` FOREIGN KEY(`StudentID`)
REFERENCES `Student` (`StudentID`);

ALTER TABLE `StudentCourse` ADD CONSTRAINT `FK_StudentCourse_Course` FOREIGN KEY(`CourseId`)
REFERENCES `Course` (`CourseId`);

ALTER TABLE `StudentCourse` ADD CONSTRAINT `FK_StudentCourse_Student` FOREIGN KEY(`StudentId`)
REFERENCES `Student` (`StudentID`);

ALTER TABLE `Teacher` ADD CONSTRAINT `FK_Teacher_Standard` FOREIGN KEY(`StandardId`)
REFERENCES `Standard` (`StandardId`);

