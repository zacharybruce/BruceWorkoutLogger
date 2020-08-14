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
            Workouts = new BindingList<WorkoutModel>(workoutList);
        }

        private void LoadExercises()
        {
            var exerciseList = _exercises.Get();
            ExerciseList = new BindingList<ExerciseModel>(exerciseList);
        }
        private void FilterExercises()
        {
            var exerciseList = _exercises.Get();

            if (SelectedWorkout?.WorkoutName.Length > 0)
            {
                var filteredExerciseList = exerciseList.Where(x => x.WorkoutName == SelectedWorkout.WorkoutName).ToList();
                ExerciseList = new BindingList<ExerciseModel>(filteredExerciseList);
            }
            else
            {
                ExerciseList = new BindingList<ExerciseModel>(exerciseList);
            }
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

        private WorkoutModel _selectedWorkout;

        public WorkoutModel SelectedWorkout
        {
            get { return _selectedWorkout; }
            set 
            { 
                _selectedWorkout = value;
                NotifyOfPropertyChange(() => SelectedWorkout);
                FilterExercises();
            }
        }


    }
}
