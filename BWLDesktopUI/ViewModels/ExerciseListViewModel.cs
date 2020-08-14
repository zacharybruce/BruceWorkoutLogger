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
    class ExerciseListViewModel : Screen
    {
        IGetWorkouts _getWorkouts;
        IExercises _exercises;

        public ExerciseListViewModel(IGetWorkouts getWorkouts, IExercises exercises)
        {
            _getWorkouts = getWorkouts;
            _exercises = exercises;
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            LoadWorkouts();
            LoadExercises();
        }

        private void LoadWorkouts()
        {
            var workoutList = _getWorkouts.Get();
            WorkoutList = new BindingList<WorkoutModel>(workoutList);
        }

        private void LoadExercises()
        {
            var exerciseList = _exercises.Add();
            ExerciseList = new BindingList<ExerciseModel>(exerciseList);
        }

        private BindingList<WorkoutModel> _workoutList;
        public BindingList<WorkoutModel> WorkoutList
        {
            get { return _workoutList; }
            set
            {
                _workoutList = value;
                NotifyOfPropertyChange(() => WorkoutList);
            }
        }

        private BindingList<ExerciseModel> _exerciseList;

        public BindingList<ExerciseModel> ExerciseList
        {
            get { return _exerciseList; }
            set 
            {
                _exerciseList = value;
                NotifyOfPropertyChange(() => ExerciseList);
            }
        }

    }
}
