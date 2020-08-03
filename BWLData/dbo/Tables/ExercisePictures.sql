CREATE TABLE [dbo].[ExercisePictures]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ExerciseId] NCHAR(10) NULL, 
    [ExercisePicture] VARBINARY(MAX) NULL
)
