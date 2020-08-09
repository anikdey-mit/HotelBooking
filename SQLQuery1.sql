CREATE TABLE [dbo].[Customers] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName] NVARCHAR (MAX) NOT NULL,
    [Email] NVARCHAR (MAX) NOT NULL,
    [PhoneNumber] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
);
CREATE TABLE [dbo].[Hotels] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NOT NULL,
    [Available Rooms] INT NOT NULL,
    [City] NVARCHAR (MAX) NOT NULL,
    [PhoneNumber] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Bookings] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
	[FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName] NVARCHAR (MAX) NOT NULL,
    [Email] NVARCHAR (MAX) NOT NULL,
	[PhoneNumber] INT NOT NULL,
    [StartDate]  DATE           NOT NULL,
    [EndDate]    DATE           NOT NULL,
	[HotelName] NVARCHAR (MAX) NOT NULL,
	[RoomNo] INT NOT NULL,
    [City] NVARCHAR (25) NOT NULL,
    [HotelNumber] INT NOT NULL,
	[CustomerId] INT NULL,
	[HotelId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id),
	FOREIGN KEY (HotelId) REFERENCES Hotels(Id)
);