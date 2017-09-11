--CREATE TABLE [dbo].[Course]
--(
--	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
--    [courseNumber] VARCHAR(10) NOT NULL, 
--    [courseName] VARCHAR(50) NOT NULL, 
--    [creditHours] INT NOT NULL, 
--    [maxEnrollment] INT NULL
--)

CREATE TABLE [dbo].[Section]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[sectionID] INT NOT NULL, 
    [sectionNumber] INT NOT NULL, 
    [courseNumber] VARCHAR(10) NOT NULL, 
    [sectionDays] VARCHAR(10) NOT NULL, 
    [sectionTime] DATETIME NOT NULL 
)