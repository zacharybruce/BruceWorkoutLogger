CREATE PROCEDURE [dbo].[sqWorkoutDetail_GetWorkouts]

AS
begin
	set nocount on

	SELECT Id, WorkoutName, DateOfWorkout
	FROM WorkoutDetail;
end
