CREATE TABLE [dbo].[Workout]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [WorkoutName] NVARCHAR(50) NOT NULL, 
    [WorkoutDescription] NVARCHAR(MAX) NOT NULL
)
