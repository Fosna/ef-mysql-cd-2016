drop database if exists todo;

create database todo;

use todo;

/* Entity Framework fix */
set global optimizer_switch='derived_merge=off';
set global optimizer_switch='derived_merge=off';

create table todoItem (
	Id int auto_increment primary key,
	Description nvarchar(1024) not null,
	TimeCreated datetime not null,
	TimeSetToDone datetime,
	TimeDeactivated datetime
);


insert into todoitem (description, timeCreated, timeSetToDone) 
values
('Buy milk', now(), NULL),
('Call Miki',now(), NULL),
('Do homework', now(), '2016-06-30 19:30:50'),
('Get to work', '2016-01-18', NULL),
('Learn ng2', '2016-06-10', NULL);

select * from todoItem;

set global optimizer_switch='derived_merge=off';

