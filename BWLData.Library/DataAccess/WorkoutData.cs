using BWLData.Library.Internal.DataAccess;
using BWLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLData.Library.DataAccess
{
    public class WorkoutData
    {
        public List<WorkoutModel> GetAllWorkouts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<WorkoutModel, dynamic>("dbo.spWorkout_GetAll", new { }, "BWLData");

            return output;
        }

        public static void AddWorkout(string workoutName, DateTime dateOfWorkout)
        {
            SqlDataAccess sql = new SqlDataAccess();

            WorkoutDetailModel p = new WorkoutDetailModel{ WorkoutName = workoutName, DateOfWorkout = dateOfWorkout };

            sql.SaveData("dbo.spWorkoutDetail_AddWorkout", p, "BWLData");
        }

        public static List<WorkoutDetailModel> GetPastWorkouts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<WorkoutDetailModel, dynamic>("dbo.sqWorkoutDetail_GetWorkouts", new { }, "BWLData");

            return output;
        }
    }
}
