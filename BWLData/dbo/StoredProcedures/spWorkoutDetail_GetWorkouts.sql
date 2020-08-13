CREATE PROCEDURE [dbo].[spWorkoutDetail_GetWorkouts]

AS
begin
	set nocount on;

	SELECT Id, WorkoutName, DateOfWorkout
	FROM WorkoutDetail;
end
