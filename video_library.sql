drop database if exists video_library;
create database video_library;
use video_library;


create table member_info(
	id int not null primary key auto_increment,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	address varchar(50),
	contact varchar(50) not null,
	membership_date date,
	status varchar(10)
);

create table movie(
	id int not null primary key auto_increment,
	name varchar(50) not null,
	genre varchar(50) not null,
	production_year date,
	status varchar(10)
);


create table loan(
	id int not null primary key auto_increment,
	loan_date date,
	return_date date,
	member_info int,
	movie int
);

