CREATE PROCEDURE [dbo].[spWorkoutDetail_AddWorkout]
	@id int,
	@workoutId int,
	@dateOfWorkout datetime2(7)
AS
begin
	set nocount on;

	insert into WorkoutDetail ( WorkoutId, DateOfWorkout)
	values (@workoutId, @dateOfWorkout);
end
