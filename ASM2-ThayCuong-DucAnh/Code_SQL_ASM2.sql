create table Author(
AuID int primary key,
AuName nvarchar(50),
AuEmail nvarchar(50)
)
insert into Author(AuID,AuName,AuEmail) values
('1','Duc Anh','ducanhaovai@gmail.com')
select * from Author

create table Librarian(
LID int primary key,
LName nvarchar(50),
LEmail  nvarchar(50),
)

insert into Librarian(LID,LName,LEmail) values
('1','German Anh','germananh@gmail.com')
('2','English German','englishgerman')
 select * from Librarian

create table Book(
BID int primary key,
BName nvarchar(50),
BLanguage nvarchar(50),
Publisher nvarchar(50),
LID int foreign key references Librarian(LID),
AuID int foreign key references Author(AuID),
)
drop table Book;

alter table Book
drop  Gender
   
insert into Book(BID,BName,BLanguage,Publisher,) values 

('B3','A','B','C')
insert into Book (BID,BName,BLanguage,Publisher,LID,AuID) values
('1','The Dog','Viet Nam','Kim Dong','1','1')
('2','The Moew','English','Kim Dong'.'1','1')


select * from Book
drop table Book

create table Student(
SID int primary key,
SName nvarchar(50),
SPhone varchar(10),
SEmail varchar(50),
Username varchar(50) foreign key references Login(Username),
DoB datetime,
Gender nvarchar(10)
)


 
 
 
alter table Student

add Gender nvarchar(10)

 
insert into Student(SID,SName,SPhone,SEmail,Username,DoB,Gender) values

('3','Huy a Anh','03456789','huyaanh@gmail.com','anhduc','2020-02-03 00:27:05.000','Female')
('4','Mai Duc Anh','34567','ducanh@gmail.com','ducanh123','2003-03-03 19:35:29.000','Male')
('5','Tran Van Khoi','1231','vankhoi@gmail.com','tranvankhoi','2022-08-13 01:55:34.183','Male')

select * from Student
SELECT SName from STUDENT
delete from Student
where
SID ='2'


convert TABLE Student
convert Gender varchar



create table Login(
Username varchar (50) primary key,
Password varchar(50),

SID int foreign key references Student(SID)
)
insert into Login values ('anhduc','123','1')

 select * from Login

ALTER TABLE Login
ADD SID int foreign key references Student(SID);
	
create table Student_Card(
CID int primary key,
Cname nvarchar(50),
BorrowDate date,
ReturnDate date,
StudentID int foreign key references Student(SID), 
)

insert into Student_Card values
(
select * from Student_Card

create table Borrow_Book(
CID int foreign key references Student_Card(CID),
BID int foreign key references Book(BID),
)

select * from Borrow_Book