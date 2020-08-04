using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BWLData.Library.DataAccess;
using BWLData.Library.Models;

namespace BWLDesktopUI.DataAccess
{
    public class GetWorkouts
    {
        public List<WorkoutModel> Get()
        {
            WorkoutData workout = new WorkoutData();
            return workout.GetAllWorkouts();
        }
    }
}
