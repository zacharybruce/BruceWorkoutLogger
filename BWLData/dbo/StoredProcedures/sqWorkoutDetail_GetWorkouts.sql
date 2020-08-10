CREATE PROCEDURE [dbo].[sqWorkoutDetail_GetWorkouts]

AS
begin
	set nocount on

	SELECT Id, WorkoutId, DateOfWorkout
	FROM WorkoutDetail;
end
