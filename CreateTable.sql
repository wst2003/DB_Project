create table Manager 
(
	ID char(4) not null primary key check(ID like '[0-9][0-9][0-9][0-9]'),
	name varchar(10) not null,
	m_password varchar(12) not null check(m_password not like '%[a-z]'),
	createdate date not null
)

create table Student(
	ID char(7) not null primary key check(ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	name varchar(10) not null,
	m_password varchar(12) not null check(m_password not like '%[a-z]'),
	createdate date not null,
	balance float not null,
	building varchar(20) not null,
	room varchar(5) not null check(room not like '%[a-z]'),
	sex char(2) not null check (sex = 'ÄÐ' or sex = 'Å®'),
	telephone char(11) not null check(telephone like  '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)

create table Good
(
	good_ID char(11) not null primary key check(good_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	name varchar(30) not null,
	amounts int not null check (amounts>0),
	specie varchar(20) not null,
	singlePrice float not null check (singlePrice>0),
	soldAmounts int not null check (soldAmounts >=0 ),
	createdate date not null,
	picture_URL varchar(100) null,
	ID char(7) not null foreign key references Student,
)

create table Orders(
	s_ID char(7) not null check(s_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	c_ID char(7) not null check(c_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	c_num_s int not null check (c_num_s > 0),
	price float not null check (price>0),
	ID char(4) null foreign key references Manager,
	primary key(s_ID,c_ID,c_num_s),
)

create table buy(
	s_ID char(7) not null check(s_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	c_ID char(7) not null check(c_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	c_num_s int not null check (c_num_s > 0),
	good_ID char(11) not null check(good_ID like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	buyAmounts int not null check (buyAmounts>0),
	primary key(s_ID,c_ID,c_num_s,good_ID,buyAmounts),
)

