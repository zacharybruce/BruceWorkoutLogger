﻿CREATE PROCEDURE [dbo].[spWorkoutDetail_AddWorkout]
	@id int,
	@DisplayText nvarchar(100),
	@workoutName nvarchar(50),
	@dateOfWorkout datetime2(7)
AS
begin
	set nocount on;

	insert into WorkoutDetail ( WorkoutName, DateOfWorkout)
	values (@workoutName, @dateOfWorkout);
end
