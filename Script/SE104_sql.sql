create DATABASE ManagementApp_DTB
create database SE104
use SE104

drop table membership
drop table meeting
drop table groupSchedule
drop table groupMembers
drop table Space_Group
drop table groups
drop table PersonalSchedule
drop table Task
drop table Project
drop table Workspace_Space
drop table Spaces
drop table users
drop table WorkSpace

SET DATEFORMAT dmy;
Create table Workspace (
    Workspace_id int identity(1,1) PRIMARY KEY,
    Workspace_name char(40)
)
Create table Space (
    Space_id int identity(1,1) PRIMARY KEY,
    Space_name char(40)
	Space_type char(40),
)


create table Users(
	User_id int identity(1,1) primary key,
	User_fullname char(40),
	User_name char(40) unique,
	User_email char(40),
	User_birthday date,
	User_password char(40),
)

Create table Space_User(
    Space_user_id int identity(1,1) Primary key,
    Space_id int References Space(Space_id),
    User_id int References Users(USer_id),
    Role char(40),
)
create table Project(
	Project_id int identity(1,1) primary key,
	Project_name char(40),
	Project_description char(100),
	WorkSpace_id int,
	FOREIGN KEY(WorkSpace_id) REFERENCES WorkSpace(WorkSpace_id)
)

create table Task(
	Task_id int identity(1,1) primary key,
	Task_name char(40),
	Task_description char(100),
	Task_start_time datetime,
	Task_end_time datetime,
	Task_status char(40),
)

Create table Task_Space(
	Task_Space_id int identity(1, 1) primary key,
	Task_id int REFERENCES Task(Task_id),
	Space_id int references Space(Space_id),
)

Create Table Assignment (
    Assigment_id int identity(1,1) Primary key,
    Task_id int References Task(Task_id),
    User_id int References Users(User_id)
)

Create table Personal_Schedule (
    Event_id int identity(1,1) primary key,
	Event_name char(40),
	Event_description char(100),
	Event_start_time datetime,
	Event_end_time datetime,
	User_id int,
	FOREIGN KEY(User_id) REFERENCES Users(User_id),
)

create table Groups(
	Group_id int identity(1,1) primary key,
	Group_name char(40),
	Group_description char(100),
	Group_admin int,
	FOREIGN KEY(Group_admin) REFERENCES Users(User_id),
)

Create table MemberShip(
    Membership_id int identity(1,1) Primary key,
    User_id int REFERENCES Users(User_id),
    Group_id int REFERENCES Groups(Group_id),
)

create table Space_Group (
    Space_Group_id int identity(1,1) Primary key,
    Space_id int,
	Group_id int,
	FOREIGN KEY(Space_id) REFERENCES Space(Space_id),
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id)
)

create table GroupSchedule(
	Event_id int identity(1,1) primary key,
	Event_name char(40),
	Event_description char(100),
	Event_start_time datetime,
	Event_end_time datetime,
	Group_id int,
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id),
)

create table Meeting(
	Meeting_id int identity(1,1) primary key,
    Group_id int,
	Meeting_name char(40),
	Meeting_description char(100),
	Meeting_start_time datetime,
	Meeting_end_time datetime,
	Organizer_id int,
	Meeting_status char(40),
	Agenda char(500),
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id),
	FOREIGN KEY(Organizer_id) REFERENCES Users(User_id),
)

-- Tạo trigger AFTER DELETE để cập nhật lại giá trị IDENTITY
CREATE TRIGGER UpdateIdentity
ON Users
AFTER DELETE
AS
BEGIN
    -- Kiểm tra xem có bản ghi nào bị xóa hay không
    IF EXISTS(SELECT * FROM deleted)
    BEGIN
        -- Lấy giá trị IDENTITY cao nhất hiện tại
        DECLARE @maxId INT;
        SELECT @maxId = MAX(User_id) FROM Users;

        -- Đặt lại giá trị seed cho cột IDENTITY
        DBCC CHECKIDENT ('Users', RESEED, @maxId);
    END;
END;


Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Dang Cong Phu','CongPhu',123456,'congphu1245@gmail.com','18/11/2003')
Insert into Workspace(Workspace_name) values('HoneperdoWS')
Insert into MemberShip values(1,1,'Admin')
Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Do Trong Tuan','TrongTuan',123456,'trongtuan@gmail.com','21/11/2003')
Insert into MemberShip values(2,1,'Member')
Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Nguyen Huy Nghia','HuuNghia',123456,'HuuNghia@gmail.com','1/1/1996')
Insert into MemberShip values(3,1,'Admin')
Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Pham Van Tan','Van Tan',123456,'TanPham@gmail.com','24/12/2003')
Insert into MemberShip values(4,1,'Member')
Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Dang Thinh','DangThinh',123456,'DangThinh@gmail.com','5/5/2003')
Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Do Trong Vu','TrongVu',123456,'TrongVu@gmail.com','26/5/2002')



Select Users.*,Membership.Role from Users,MemberShip where MemberShip.User_id=Users.User_id and MemberShip.Workspace_id=1

select * from users
select * from Workspace
select * from membership

delete from membership where User_id=5 and Workspace_id=1

