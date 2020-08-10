using BWLData.Library.Models;
using BWLDesktopUI.DataAccess;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLDesktopUI.ViewModels
{
    class WorkoutHistoryViewModel : Screen
    {
        IGetWorkouts _getWorkouts;

        public WorkoutHistoryViewModel(IGetWorkouts getWorkouts)
        {
            _getWorkouts = getWorkouts;
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            LoadWorkoutHistory();
        }

        public void LoadWorkoutHistory()
        {
            List<string> workouts = new List<string>();

            var workoutHistoryList = WorkoutHistory.Get();
            var allWorkouts = _getWorkouts.Get();

            var PastWorkoutsJoin = workoutHistoryList.Join(allWorkouts, x => x.WorkoutId, y => y.Id, (x,y) => new { x.Id, y.WorkoutName }).ToList();

            foreach (var item in PastWorkoutsJoin)
            {
                workouts.Add(item.WorkoutName);
            }

            PastWorkouts = workouts;
        }

        private List<string> _pastWorkouts;

        public List<string> PastWorkouts
        {
            get { return _pastWorkouts; }
            set 
            {
                _pastWorkouts = value;
                NotifyOfPropertyChange(() => PastWorkouts);
            }
        }

    }
}
