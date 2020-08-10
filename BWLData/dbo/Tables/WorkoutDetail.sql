CREATE TABLE [dbo].[WorkoutDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkoutId] INT NOT NULL, 
    [DateOfWorkout] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_WorkoutDetail_ToWorkout] FOREIGN KEY ([WorkoutId]) REFERENCES Workout(Id)
)
