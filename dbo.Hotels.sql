CREATE TABLE [dbo].[Hotels] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [City]        NVARCHAR (MAX) NOT NULL,
	[Available Rooms] INT NOT NULL,
    [PhoneNumber] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

