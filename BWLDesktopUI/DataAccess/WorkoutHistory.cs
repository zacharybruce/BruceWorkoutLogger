using BWLData.Library.DataAccess;
using BWLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLDesktopUI.DataAccess
{
    public class WorkoutHistory
    {
        public static List<WorkoutDetailModel> Get()
        {
            return WorkoutData.GetPastWorkouts();
        }

        public static void Delete(int id)
        {
            WorkoutData.DeleteWorkout(id);
        }

        public static void Add(string workoutName, DateTime dateOfWorkout)
        {
            WorkoutData.AddWorkout(workoutName, dateOfWorkout);
        }
    }
}
