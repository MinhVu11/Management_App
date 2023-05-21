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

Select * from Workspace_Space,Spaces where Workspace_Space.Space_id=Spaces.Space_id and Workspace_id=4 and Spaces.Space_type='public'

Select Spaces.* from Workspace_Space,Spaces,Membership where MemberShip.Workspace_id = Workspace_Space.Workspace_id and Workspace_Space.Space_id=Spaces.Space_id and Workspace_id=4 and MemberShip.User_id=1and Spaces.Space_type='private'

SELECT Spaces.*
FROM Workspace_Space, Spaces, Membership
WHERE Membership.Workspace_id = Workspace_Space.Workspace_id
    AND Workspace_Space.Space_id = Spaces.Space_id
    AND Workspace_id = 4
    AND Membership.User_id = 1
    AND Spaces.Space_type = 'private'


create table Workspace(
	Workspace_id int identity(1,1) primary key,
	Workspace_name char(40)
)
create table Users(
	User_id int identity(1,1) primary key,
	User_fullname char(40),
	User_name char(40) unique,
	User_email char(40),
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
	WorkSpace_id int,
	FOREIGN KEY(WorkSpace_id) REFERENCES WorkSpace(WorkSpace_id)
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

