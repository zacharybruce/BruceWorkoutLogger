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
            BindingList<WorkoutDetailModel> workouts = new BindingList<WorkoutDetailModel>();

            List<WorkoutDetailModel> workoutHistoryList = WorkoutHistory.Get().OrderBy(x => x.DateOfWorkout).ToList();

            PastWorkouts = new BindingList<WorkoutDetailModel>(workoutHistoryList);
        }

        private BindingList<WorkoutDetailModel> _pastWorkouts;

        public BindingList<WorkoutDetailModel> PastWorkouts
        {
            get { return _pastWorkouts; }
            set 
            {
                _pastWorkouts = value;
                NotifyOfPropertyChange(() => PastWorkouts);
            }
        }

        private string _selectedPastWorkout;
        public string SelectedPastWorkout
        {
            get { return _selectedPastWorkout; }
            set 
            {
                _selectedPastWorkout = value;
                NotifyOfPropertyChange(() => SelectedPastWorkout);
                NotifyOfPropertyChange(() => CanDeleteWorkout);
            }
        }

        public void DeleteWorkout()
        {
            //NotifyOfPropertyChange(() => CanDeleteWorkout);
            //PastWorkouts.RemoveAt(PastWorkouts.IndexOf(SelectedPastWorkout));
            //NotifyOfPropertyChange(() => PastWorkouts);
        }

        public bool CanDeleteWorkout
        {
            get
            {
                bool output = false;

                if (SelectedPastWorkout?.Length > 0)
                {
                    output = true;
                }

                return output;
            }            
        }

    }
}
