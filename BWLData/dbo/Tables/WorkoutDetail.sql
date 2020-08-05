CREATE TABLE [dbo].[WorkoutDetail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [WorkoutId] INT NULL, 
    [Intensity] INT NULL, 
    [DateOfWorkout] DATETIME2 NOT NULL 
)
