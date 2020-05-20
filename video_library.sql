drop database if exists video_library;
create database video_library;
use video_library;


create table member_info(
	id int not null primary key auto_increment,
	first_name varchar(50) not null,
	last_name varchar(50) not null,
	address varchar(50) default null,
	contact varchar(50) not null,
	membership_date datetime not null default current_timestamp,
	status varchar(10) default 'Active',
	loans_num smallint default 0
);

create table movie(
	id int not null primary key auto_increment,
	name varchar(50) not null,
	genre varchar(50) not null,
	production_year smallint not null,
	on_loan boolean not null default 0
);


create table loan(
	id int not null primary key auto_increment,
	loan_date datetime not null default current_timestamp,
	reserve_date datetime default null,
	member_info int not null,
	movie int not null
);

create table loan_history(
	id int not null primary key auto_increment,
	return_date datetime not null default current_timestamp,
	loan_date datetime,
	reserve_date datetime,
	member_info int,
	movie int	
);


alter table loan add foreign key (member_info) references member_info(id);
alter table loan add foreign key (movie) references movie(id);

alter table loan_history add foreign key (member_info) references member_info(id);
alter table loan_history add foreign key (movie) references movie(id);



# select * from member_info;


insert into member_info(first_name, last_name, address, contact, status, loans_num)
values('Pero','Perić','K.Tomislava 54','0981700329','Active',30),
('Marko','Ivić','Bračka 5','0978659846','Active',45),
('Alojza','Perić','Vukovarska 12','0995468722','Active',55),
('Željko','Pejić','Vukovarska 151','0914421567','Active',60),
('Alfred','Horvat','Krstova 2','0985556789','Inactive',1),
('Petra','Lorić','Krste Frankopana 95','098172223','Active',14);


# select * from movie;


insert into movie(name, genre, production_year)
values('Matrix','Sci-fi',1999),
('Gladiator','Action',2000),
('Dark Knight','Action',2008),
('Terminator','Action',1984),
('Lord of the Rings','Adventure',2001),
('Slamdog Milionaire','Drama',2008),
('Hangover','Comedy',2009),
('Casablanca','Drama',1942),
('The Wizard of Oz','Adventure',1939),
('The Godfather','Crime',1972),
('From Russian with Love','Action',1963);


# select * from loan;
# describe loan;

# create trigger is_on_loan 
# after insert on loan 
# for each row
# update movie
# set on_loan = 1
# where id = ?

insert into loan(reserve_date, member_info, movie)
values(curdate() + interval 7 day, 1, 3),
(curdate() + interval 7 day, 4, 7),
(curdate() + interval 7 day, 5, 2);

update movie set on_loan = 1 where id in(3,7,2);



# TASKS TO DO

# 1. SELECT * FROM movie WHERE genre = 'Action';

# 2. SELECT * FROM movie where on_loan = 1;

# 3. UPDATE movie SET genre = 'Classic' WHERE production_year < 1980;
#    SELECT * FROM movie;

# 4. INSERT INTO loan_history(loan_date, reserve_date, member_info, movie)
#    SELECT loan_date, reserve_date, member_info, movie from loan
#    WHERE id=1;
#
#    DELETE FROM loan
#    WHERE id = 1;   

# 5. UPDATE member_info SET status = 'Frequent' WHERE loans_num > 50;
#    select * from member_info;