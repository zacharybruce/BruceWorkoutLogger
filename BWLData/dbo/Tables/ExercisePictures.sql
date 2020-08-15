CREATE TABLE [dbo].[ExercisePictures]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExerciseId] INT NOT NULL, 
    [ExercisePicturePath] NVARCHAR(MAX) NULL
)
