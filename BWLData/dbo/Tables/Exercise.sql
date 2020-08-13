CREATE TABLE [dbo].[Exercise]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExerciseName] NVARCHAR(50) NOT NULL, 
    [ExerciseDescription] NVARCHAR(MAX) NOT NULL, 
    [WorkoutName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Exercise_ToWorkout] FOREIGN KEY ([WorkoutName]) REFERENCES Workout(WorkoutName) 
)
