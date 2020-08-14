using BWLData.Library.Models;
using System.Collections.Generic;

namespace BWLDesktopUI.DataAccess
{
    public interface IExercises
    {
        List<ExerciseModel> Get();
    }
}