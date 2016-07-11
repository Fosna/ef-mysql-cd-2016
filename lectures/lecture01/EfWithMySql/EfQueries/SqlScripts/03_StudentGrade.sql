update student set StudentName = 'Jack' where Id = 1;
update student set StudentName = 'Jill' where Id = 2;
update student set StudentName = 'Steve' where Id = 3;
update student set StudentName = 'Senko' where Id = 4;


alter table studentcourse add column (
	Grade int null
);

update studentcourse set Grade = 2 where StudentId = 1 and CourseId = 3;
update studentcourse set Grade = 1 where StudentId = 1 and CourseId = 4;
update studentcourse set Grade = 4 where StudentId = 1 and CourseId = 5;

update studentcourse set Grade = 5 where StudentId = 2 and CourseId = 3;
update studentcourse set Grade = 5 where StudentId = 2 and CourseId = 4;
update studentcourse set Grade = 5 where StudentId = 2 and CourseId = 5;

update studentcourse set Grade = 5 where StudentId = 3 and CourseId = 4;

