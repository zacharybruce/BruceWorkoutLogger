CREATE PROCEDURE [dbo].[spWorkout_GetAll]
AS
begin
	set nocount on;
	SELECT id, WorkoutName, WorkoutDescription
	from dbo.Workout;
end
