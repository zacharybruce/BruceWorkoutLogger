using BWLDesktopUI.DataAccess;
using BWLData.Library.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLDesktopUI.ViewModels
{
    public class WorkoutLogViewModel : Screen
    {
        IGetWorkouts _getWorkouts;

        public WorkoutLogViewModel(IGetWorkouts getWorkouts)
        {
            _getWorkouts = getWorkouts;
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            LoadWorkouts();
        }

        private void LoadWorkouts()
        {
            var workoutList = _getWorkouts.Get();
            Workouts = new BindingList<WorkoutModel>(workoutList);
        }

        private BindingList<WorkoutModel> _workouts;

        public BindingList<WorkoutModel> Workouts
        {
            get { return _workouts; }
            set 
            { 
                _workouts = value;
                NotifyOfPropertyChange(() => Workouts);
            }
        }

    }
}
