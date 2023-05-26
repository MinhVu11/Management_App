create DATABASE ManagementApp_DTB

Create table Workspace (
    Workspace_id int identity(1,1) PRIMARY KEY,
    Workspace_name char(40)
)

Create table Space (
    Space_id int identity(1,1) PRIMARY KEY,
    Space_name char(40)
)

Create table Workspace_space (
    Workspace_space_id int identity(1,1) PRIMARY KEY,
    Workspace_id int Foreign key References Workspace(Workspace_id) ,
    Space_id int Foreign key References Space(Space_id)
)

create table Users(
	User_id int identity(1,1) primary key,
	User_fullname char(40),
	User_name char(40) unique,
	User_email char(40),
	User_password char(40),
)

Create table Space_User(
    Space_user_id int identity(1,1) Primary key,
    Space_id int References Space(Space_id),
    User_id int References Users(USer_id),
    Role char(40),
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

alter table Space add Space_type char(40)

select Space_name from Workspace, Workspace_space, Space where Workspace.Workspace_id = Workspace_space.Workspace_id and Space.Space_id = Workspace_space.Space_id