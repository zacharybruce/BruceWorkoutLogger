CREATE PROCEDURE [dbo].[spWorkout_GetAll]
AS
begin
	set nocount on;
	SELECT WorkoutName, WorkoutDescription
	from dbo.Workout;
end
