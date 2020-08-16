CREATE PROCEDURE [dbo].[spExercisePictures_GetAll]

AS
begin
	SELECT Id, ExerciseId, ExercisePicturePath
	FROM ExercisePictures;
end
