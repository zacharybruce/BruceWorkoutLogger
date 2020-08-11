CREATE PROCEDURE [dbo].[spWorkoutDetail_DeleteWorkout]
	@id int
AS
begin
	DELETE FROM WorkoutDetail
	WHERE Id = @id;
end