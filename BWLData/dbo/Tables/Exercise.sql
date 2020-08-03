CREATE TABLE [dbo].[Exercise]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ExerciseName] NVARCHAR(50) NOT NULL, 
    [ExerciseDescription] NVARCHAR(MAX) NOT NULL, 
    [WorkoutId] INT NOT NULL 
)
