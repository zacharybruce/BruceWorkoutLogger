using BWLData.Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLDesktopUI.DataAccess
{
    public class AddWorkoutToHistory
    {
        public static void Add(string workoutName, DateTime dateOfWorkout)
        {
            WorkoutData.AddWorkout(workoutName, dateOfWorkout);
        }
    }
}
