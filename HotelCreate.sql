create database Hotel

go

use Hotel

go

create table tblHotelRoom
(
	Id int not null identity(1, 1),
	Number int not null,
	Reserved bit not null, 
	RoomQuantity int not null,

	constraint PK_HotelRoom_Id primary key(Id)
);

create table tblGuest
(
	Id int not null identity(1, 1),
	Name nvarchar(64) not null,
	Surname nvarchar(64) not null,
	Email nvarchar(64) not null,
	Phone nvarchar(64) not null,

	constraint PK_Guest_Id primary key(Id)
);

create table tblReservation
(
	Id int not null identity(1, 1),
	Arrival datetime not null,
	Departure datetime not null,
	GuestId int not null,
	RoomId int not null,

	constraint PK_Reservation_Id primary key (Id),
	constraint FK_Reservation_Guest_Id foreign key (GuestId) references tblGuest (Id),
	constraint FK_Reservation_HotelRoom foreign key (RoomId) references tblHotelRoom (Id)
);