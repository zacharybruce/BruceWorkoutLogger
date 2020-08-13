CREATE PROCEDURE [dbo].[spWorkoutDetail_DeleteWorkout]
	@id int
AS
begin
	set nocount on;

	DELETE FROM WorkoutDetail
	WHERE Id = @id;
end