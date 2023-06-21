drop 
create database SE104
use SE104

SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'SE104';

drop table shareTask
drop table Membership
drop table participants
drop table Meeting
drop table GroupSchedule
drop table Group_Member
drop table Assignment
drop table groups
drop table Personal_Schedule
drop table Notifications
drop table Task_Space
drop table Task
drop table Workspace_Space
drop table Space
drop table users
drop table WorkSpace

SET DATEFORMAT dmy;
Create table Workspace (
    Workspace_id int identity(1,1) PRIMARY KEY,
    Workspace_name char(40)
)
Create table Space (
    Space_id int identity(1,1) PRIMARY KEY,
    Space_name char(40),
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


create table Task(
	Task_id int identity(1,1) primary key,
	Task_name char(40),
	Task_description char(100),
	Task_start_time datetime,
	Task_end_time datetime,
	Task_status char(40),
)
CREATE TABLE TaskAttachments
(
    AttachmentID INT IDENTITY(1,1) PRIMARY KEY,
    FileName NVARCHAR(100) NOT NULL,
    FileData VARBINARY(MAX),
    Task_id int REFERENCES Task(Task_id),
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

Create table ShareTask(
	ShareTask_id int identity(1,1) Primary key,
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
	Space_id int,
	FOREIGN KEY(Space_id) REFERENCES Space(Space_id),
)

create table Group_Member(
	Group_Member int identity(1,1) primary key,
	Group_id int,
	User_id int,
	role char(50),
	FOREIGN KEY(Group_id) REFERENCES Groups(Group_id),
	FOREIGN KEY(User_id) REFERENCES Users(User_id)
)

create table Workspace_Space(
	Workspace_id int,
	Space_id int,
	PRIMARY KEY(Workspace_id,Space_id),
	FOREIGN KEY(Space_id) REFERENCES Space(Space_id),
	FOREIGN KEY(Workspace_id) REFERENCES Workspace(Workspace_id)
)

 create table MemberShip(
	 User_id int,
	 Workspace_id int,
	 role varchar(40),
	 FOREIGN KEY(User_id) REFERENCES Users(User_id),
	 FOREIGN KEY(Workspace_id) REFERENCES Workspace(Workspace_id),
	 PRIMARY KEY(User_id,Workspace_id),
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
	Meeting_status char(40),
	Meeting_location char(40),
	Organizer_id int,
	Space_id int,
	Agenda char(500), 	
	Workspace_id int,
	FOREIGN KEY(Workspace_id) REFERENCES Workspace(Workspace_id),
	FOREIGN KEY(Space_id) REFERENCES Space(Space_id),
	FOREIGN KEY(Organizer_id) REFERENCES Users(User_id),
)
CREATE TABLE MeetingAttachments
(
    AttachmentID INT IDENTITY(1,1) PRIMARY KEY,    
    FileName NVARCHAR(100) NOT NULL,
    FileData VARBINARY(MAX),
    Meeting_id int REFERENCES Meeting(Meeting_id),
)

create table Participants(
	Meeting_id int,
	User_id int,
	FOREIGN KEY(User_id) REFERENCES Users(User_id),
	FOREIGN KEY(Meeting_id) REFERENCES Meeting(Meeting_id),
	PRIMARY KEY(Meeting_id,User_id)
)

CREATE TABLE Notifications (
    Notification_id INT IDENTITY(1, 1) PRIMARY KEY,
    Notification_type CHAR(40),
    Notification_message CHAR(100),
    Event_id INT,
    User_id INT REFERENCES Users(User_id),
    IsRead BIT DEFAULT 0,
    Created_at DATETIME,
);


CREATE TRIGGER TaskAssignmentNotification
ON Assignment
AFTER INSERT
AS
BEGIN
    -- Lấy thông tin về task và user_id từ bảng Assignment
    DECLARE @TaskName CHAR(40);
    DECLARE @UserName CHAR(40);

    SELECT @TaskName = Task.Task_name, @UserName = Users.User_name
    FROM inserted
    INNER JOIN Task ON Task.Task_id = inserted.Task_id
    INNER JOIN Users ON Users.User_id = inserted.User_id;

    -- Thêm thông báo vào bảng Notifications
    INSERT INTO Notifications (Notification_type, Notification_message, Event_id, User_id, Created_at)
    VALUES ('Task', 'You have been assigned to task "' + @TaskName + '"', (SELECT Task_id FROM inserted), (SELECT User_id FROM inserted), GETDATE());
END
GO

CREATE TRIGGER MeetingParticipantsNotification
ON Participants
AFTER INSERT
AS
BEGIN
    -- Lấy thông tin về meeting và user_id từ bảng Participants
    DECLARE @MeetingName CHAR(40);
    DECLARE @UserName CHAR(40);

    SELECT @MeetingName = Meeting.Meeting_name, @UserName = Users.User_name
    FROM inserted
    INNER JOIN Meeting ON Meeting.Meeting_id = inserted.Meeting_id
    INNER JOIN Users ON Users.User_id = inserted.User_id;

    -- Thêm thông báo vào bảng Notifications
    INSERT INTO Notifications (Notification_type, Notification_message, Event_id, User_id, Created_at)
    VALUES ('Meeting', 'You have been added as a participant in meeting "' + @MeetingName + '"', (SELECT Meeting_id FROM inserted), (SELECT User_id FROM inserted), GETDATE());
END
GO



Insert into Users(User_fullname,User_name,User_password,User_email,User_birthday) values ('Dang Cong Phu','CongPhu',123456,'congphu@gmail.com','18/11/2003')
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
Insert into Space(Space_name,Space_type) values ('space1','public')
Insert into Space(Space_name,Space_type) values ('space2','private')
Insert into Space(Space_name,Space_type) values ('space3','private')
Insert into Space(Space_name,Space_type) values ('space4','private')
Insert into Workspace_space values (1,1)
Insert into Workspace_space values (1,2)
Insert into Workspace_space values (1,3)
Insert into Workspace_space values (1,4)
Insert into Groups(Space_id) values(2)
Insert into Groups(Space_id) values(3)
Insert into Groups(Space_id) values(4)
Insert into Group_Member(Group_id,User_id,role) values(1,1,'admin')
Insert into Group_Member(Group_id,User_id,role) values(2,1,'member')
Insert into Group_Member(Group_id,User_id,role) values(3,1,'member')
Insert into Task values('Task1','Báo cáo dự án','2023-11-11 13:23:44','2023-11-12 13:23:44','Khẩn cấp')
Insert into Task values('Task2','report','2023-11-11 13:23:44','2023-11-12 13:23:44','normal')
Insert into Task values('Task3','meeting customer','2023-11-11 13:23:44','2023-11-12 13:23:44','urgen')
Insert into Task values('Task4','dealwith bosss','2023-11-11 13:23:44','2023-11-12 13:23:44','extremly')
Insert into Task_Space values(1,1)


Select Users.*,Membership.Role from Users,MemberShip where MemberShip.User_id=Users.User_id and MemberShip.Workspace_id=1

select * from users
select * from Workspace
select * from Space
select * from Groups
select * from Group_Member
select * from Workspace_space
select * from membership
select * from task
select * from Task_Space
select * from meeting
select * from assignment
select * from notifications


Select * from Notifications where User_id=1