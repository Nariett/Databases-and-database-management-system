CREATE DATABASE Films;
CREATE TABLE Film (
    ID INT PRIMARY KEY,
    FilmName VARCHAR(255) NOT NULL,
    Studio VARCHAR(255) NOT NULL,
    ReleaseYear INT NOT NULL,
    County VARCHAR(255),
    Duration INT NOT NULL,
    Genre VARCHAR(255) NOT NULL
);

CREATE TABLE Person (
    ID INT PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL,
    DateOfBirth DATE,
    DateOfDeath DATE
);

CREATE TABLE Movie_Participants(
    ID INT PRIMARY KEY,
    Film INT REFERENCES Film(ID),
    Person INT REFERENCES Person(ID),
    Participation VARCHAR(255) NOT NULL,
    RoleInFilm VARCHAR(255)
);

CREATE TABLE Awards (
    ID INT PRIMARY KEY,
    AwardsName VARCHAR(255) NOT NULL,
    Nomination VARCHAR(255),
    YearAward INT
);

INSERT INTO Film (ID, FilmName, Studio, ReleaseYear, County, Duration, Genre)
VALUES
    (1, 'Бойцовский клуб', '20th Century Fox', 1999, 'США', 139, 'Драма'),
    (2, 'Звездные войны 4', 'Lucasfilm', 1977, 'США', 121, 'Фантастика'),
    (3, 'Пираты Карибского моря 1', 'Walt Disney Pictures', 2003, 'США', 143, 'Приключения'),
    (4, 'Драйв', 'FilmDistrict', 2011, 'США', 100, 'Боевик'),
    (5, 'Криминальное чтиво', 'Miramax Films', 1994, 'США', 154, 'Криминал');

INSERT INTO Person (ID, FullName, DateOfBirth, DateOfDeath)
VALUES
    (1, 'Брэд Питт', '1963-12-18', NULL),
    (2, 'Эдвард Нортон', '1969-08-18', NULL),
    (3, 'Харрисон Форд', '1942-07-13', NULL);

INSERT INTO Movie_Participants (ID, Film, Person, Participation, RoleInFilm)
VALUES
    (1, 1, 1, 'Актер', 'Тайлер Дёрден'),
    (2, 1, 2, 'Актер', 'Нарколог'),
    (3, 2, 3, 'Актер', 'Ган Соло'),
    (4, 3, 1, 'Актер', 'Джек Воробей'),
    (5, 4, 1, 'Режиссер', NULL),
    (6, 4, 2, 'Актер', 'Водитель'),
    (7, 5, 3, 'Актер', 'Жуль Пфф'),
    (8, 5, 2, 'Актер', 'Вернон Таск');

INSERT INTO Awards (ID, AwardsName, Nomination, YearAward)
VALUES
    (1, 'Оскар', 'Лучший актер', 1996),
    (2, 'Золотой глобус', 'Лучший актер', 1996),
    (3, 'Оскар', 'Лучший режиссёр', 2012),
    (4, 'Золотой глобус', 'Лучший фильм', 2012),
    (5, 'Оскар', 'Лучший фильм', 1995),
    (6, 'Золотой глобус', 'Лучший сценарий', 1995);

CREATE FUNCTION CaclAge( @BirthDate DATE, @FilmYear INT)
RETURNS INT
AS
BEGIN
    DECLARE @ActorAge INT;
    SET @ActorAge = @FilmYear - YEAR(@BirthDate);
    RETURN @ActorAge;
END;

DECLARE @BirthDate DATE = '1980-05-15';
DECLARE @FilmYear INT = 2023; 
DECLARE @Result INT;
SET @Result = dbo.CaclAge(@BirthDate, @FilmYear);
SELECT @Result AS ActorAge;

CREATE FUNCTION dbo.FullName(@FullName VARCHAR(255))
RETURNS VARCHAR(255)
AS
BEGIN
    DECLARE @LastName VARCHAR(255);
    DECLARE @FirstName VARCHAR(255);
    DECLARE @MiddleName VARCHAR(255);
    DECLARE @Result VARCHAR(255);
    SELECT @LastName = PARSENAME(REPLACE(@FullName, ' ', '.'), 3), @FirstName = PARSENAME(REPLACE(@FullName, ' ', '.'), 2), @MiddleName = PARSENAME(REPLACE(@FullName, ' ', '.'), 1);
    IF @LastName IS NULL OR @FirstName IS NULL
		BEGIN
			SET @Result = '##########';
		END
    ELSE
		BEGIN
			SET @Result = @LastName + ' ' + LEFT(@FirstName, 1) + '.' + LEFT(@MiddleName, 1) + '.';
		END
    RETURN @Result;
END;

DECLARE @FormattedName VARCHAR(255);
SET @FormattedName = dbo.FullName('Брэд Питт Гослингович');
SELECT @FormattedName AS FormattedName;

CREATE FUNCTION FormatData(@Duration INT)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Hours INT;
    DECLARE @Minutes INT;
    DECLARE @Result VARCHAR(50);
    SET @Hours = @Duration / 60;
    SET @Minutes = @Duration % 60;
    SET @Result = CAST(@Hours AS VARCHAR(10)) + ' ч. ' + CAST(@Minutes AS VARCHAR(10)) + ' м.';
    RETURN @Result;
END;

DECLARE @Duration INT = 135;
DECLARE @FormattedDuration VARCHAR(50);
SET @FormattedDuration = dbo.FormatData(@Duration);
SELECT @FormattedDuration AS FormattedDuration;
