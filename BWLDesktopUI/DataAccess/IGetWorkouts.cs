using BWLData.Library.Models;
using System.Collections.Generic;

namespace BWLDesktopUI.DataAccess
{
    public interface IGetWorkouts
    {
        List<WorkoutModel> Get();
    }
}