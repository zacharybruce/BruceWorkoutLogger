CREATE TABLE [dbo].[WorkoutDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkoutName] NVARCHAR(50) NOT NULL, 
    [DateOfWorkout] DATETIME2 NOT NULL, 
    CONSTRAINT [FK_WorkoutDetail_ToWorkout] FOREIGN KEY ([WorkoutName]) REFERENCES Workout(WorkoutName)
)
