drop database if exists todo;

create database todo;

use todo;

create table todoItem (
	id int auto_increment primary key,
    description nvarchar(1024) not null
);

select *
from todoItem;