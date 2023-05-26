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
create table Workspace(
	Workspace_id int identity(1,1) primary key,
	Workspace_name char(40)
)
create table Users(
	User_id int identity(1,1) primary key,
	User_fullname char(40),
	User_name char(40) unique,
	User_email char(40),
	User_birthday date,
	User_password char(40),
)
create table Spaces(
	Space_id int identity(1,1) primary key,
	Space_name char(50),
	Space_type char(40),
)

create table Project(
	Project_id int identity(1,1) primary key,
	Project_name char(40),
	Project_description char(100),
	Space_id int,
	FOREIGN KEY(Space_id) REFERENCES Spaces(Space_id)
)

create table Task(
	Task_id int identity(1,1) primary key,
	Task_name char(40),
	Task_description char(100),
	Project_id int,
	Task_due_date datetime,
	Task_start_time datetime,
	Task_end_time datetime,
	Task_status char(40),
	Assiged_user int,
	FOREIGN KEY(Project_id) REFERENCES Project(Project_id),
	FOREIGN KEY(Assiged_user) REFERENCES Users(User_id),
)

create table PersonalSchedule(
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
	User_id int,
	FOREIGN KEY(User_id) REFERENCES Users(User_id),
	FOREIGN KEY(Group_admin) REFERENCES Users(User_id),
)

create table GroupMembers(
	Group_id INT,
	User_id INT,
	role VARCHAR(255),
	PRIMARY KEY (Group_id, User_id),
	FOREIGN KEY (Group_id) REFERENCES Groups(Group_id),
	FOREIGN KEY (User_id) REFERENCES Users(User_id)
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
	Meeting_name char(40),
	Meeting_description char(100),
	Meeting_start_time datetime,
	Meeting_end_time datetime,
	Organizer_id int,
	Meeting_status char(40),
	Group_id int,
	Agenda char(500),
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id),
	FOREIGN KEY(Organizer_id) REFERENCES Users(User_id),
)
 create table MemberShip(
	 User_id int,
	 Workspace_id int,
	 role varchar(40),
	 FOREIGN KEY(User_id) REFERENCES Users(User_id),
	 FOREIGN KEY(Workspace_id) REFERENCES Workspace(Workspace_id),
	 PRIMARY KEY(User_id,Workspace_id),
)
create table Workspace_Space(
	Workspace_id int,
	Space_id int,
	PRIMARY KEY(Workspace_id,Space_id),
	FOREIGN KEY(Space_id) REFERENCES Spaces(Space_id),
	FOREIGN KEY(Workspace_id) REFERENCES Workspace(Workspace_id)
)
create table Space_Group(
	Space_id int,
	Group_id int,
	PRIMARY KEY(Space_id,Group_id),
	FOREIGN KEY(Space_id) REFERENCES Spaces(Space_id),
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id)
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

