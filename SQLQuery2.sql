CREATE TABLE [dbo].[Location]
(
[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
[Name] VARCHAR(MAX) NOT NULL,
[Description] VARCHAR(MAX) NOT NULL,
[Latitude] NUMERIC(10, 8) NOT NULL,
[Longitude] NUMERIC(11, 8) NOT NULL,
CONSTRAINT CK_Latitude CHECK (Latitude >= -90 AND Latitude <= 90),
CONSTRAINT CK_Longtitude CHECK (Longitude >= -180 AND Longitude <=
180)
)