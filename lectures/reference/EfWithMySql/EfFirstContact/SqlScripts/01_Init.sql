drop database if exists Todo;

create database Todo;
use Todo;

drop table if exists TodoItem;

create table TodoItem (
	Id int auto_increment primary key,
    Description nvarchar(1024) not null,
    TimeCreated timestamp not null,
    TimeSetToDone timestamp null
);

insert into TodoItem(Description, TimeCreated, TimeSetToDone) values 
('Buy milk', current_timestamp() - interval 1 hour, null),
('Call Miki', current_timestamp() - interval 1 hour, null),
('Do homework', current_timestamp() - interval 4 hour, current_timestamp() - interval 2 hour);

