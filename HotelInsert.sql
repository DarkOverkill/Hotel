use Hotel;

INSERT INTO [dbo].[tblHotelRoom]
			([Number], [Reserved], [RoomQuantity])
	VALUES
		(101, 0, 2),
		(102, 0, 1),
		(103, 0, 2),
		(201, 0, 1),
		(202, 1, 1),
		(203, 0, 3);

INSERT INTO [dbo].[tblGuest]
			([Name], [Surname], [Email], [Phone])
	VALUES
		('Jhon', 'Connor', 'jc@gmail.com', '0-000-000'),
		('Sarah', 'Connor', 'sc@gmail.com', '1-111-111'),
		('Kyle', 'Reese', 'kr@gmail.com', '2-222-222');

