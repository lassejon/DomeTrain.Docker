CREATE DATABASE Podcasts
GO

USE Podcasts
GO

CREATE TABLE Podcast
(
    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    Title NVARCHAR(MAX) NOT NULL
)
GO

INSERT INTO Podcasts.dbo.Podcast (Title)
VALUES
('Podcast 1'),
('Podcast 2'),
('Podcast 3'),
('Podcast 4'),
('Podcast 5'),
('Podcast 6'),
('Podcast 7')
GO