CREATE PROCEDURE [dbo].[spExercise_GetExercises]

AS
begin
	set nocount on;

	SELECT Id, ExerciseName, ExerciseDescription, WorkoutName
	FROM Exercise;
end
