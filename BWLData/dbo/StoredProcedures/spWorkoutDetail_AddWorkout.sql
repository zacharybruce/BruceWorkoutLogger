CREATE PROCEDURE [dbo].[spWorkoutDetail_AddWorkout]
	@id int,
	@workoutName nvarchar(50),
	@dateOfWorkout datetime2(7)
AS
begin
	set nocount on;

	insert into WorkoutDetail ( WorkoutId, DateOfWorkout)
	values (@workoutName, @dateOfWorkout);
end
