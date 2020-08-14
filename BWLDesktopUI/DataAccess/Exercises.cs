using BWLData.Library.DataAccess;
using BWLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLDesktopUI.DataAccess
{
    public class Exercises : IExercises
    {
        public List<ExerciseModel> Get()
        {
            return WorkoutData.GetExercises();
        }
    }
}
