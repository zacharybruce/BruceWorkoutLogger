CREATE TABLE [dbo].[Workout]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkoutName] NVARCHAR(50) NOT NULL, 
    [WorkoutDescription] NVARCHAR(MAX) NOT NULL
)
