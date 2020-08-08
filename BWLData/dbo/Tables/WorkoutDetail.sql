CREATE TABLE [dbo].[WorkoutDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkoutId] INT NULL, 
    [DateOfWorkout] DATETIME2 NOT NULL 
)
