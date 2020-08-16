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
    public class ExerciseDescriptionViewModel : Screen
    {
        IGetWorkouts _getWorkouts;
        IExercises _exerciseList;

        public ExerciseDescriptionViewModel(IGetWorkouts getWorkouts, IExercises exercises)
        {
            _getWorkouts = getWorkouts;
            _exerciseList = exercises;
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            LoadWorkouts();
            Exercises = LoadExercises();
        }

        private void LoadWorkouts()
        {
            var workoutList = _getWorkouts.Get();
            Workouts = new BindingList<WorkoutModel>(workoutList);
        }

        private BindingList<ExerciseModel> LoadExercises()
        {
            var exerciseList = new BindingList<ExerciseModel>(_exerciseList.Get());
            return exerciseList;
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

        private WorkoutModel _chosenWorkout;

        public WorkoutModel ChosenWorkout
        {
            get { return _chosenWorkout; }
            set 
            { 
                _chosenWorkout = value;
                NotifyOfPropertyChange(() => ChosenWorkout);
                FilterExercises();
            }
        }

        private BindingList<ExerciseModel> _exercises;

        public BindingList<ExerciseModel> Exercises
        {
            get { return _exercises; }
            set 
            {
                _exercises = value;
                NotifyOfPropertyChange(() => Exercises);
                NotifyOfPropertyChange(() => ChosenWorkout);
            }
        }

        private ExerciseModel _selectedExercise;

        public ExerciseModel SelectedExercise
        {
            get { return _selectedExercise; }
            set 
            { 
                _selectedExercise = value;
                NotifyOfPropertyChange(() => SelectedExercise);
                NotifyOfPropertyChange(() => ExerciseDescription);
                NotifyOfPropertyChange(() => ExercisePicture);
                ExerciseDescription = SelectedExercise?.ExerciseDescription;
                ExercisePicture = GetExercisePicture();
            }
        }

        public void FilterExercises()
        {
            var fullExerciseList = LoadExercises();
            var filteredExerciseList = fullExerciseList.Where(x => x.WorkoutName == ChosenWorkout.WorkoutName).ToList();
            Exercises = new BindingList<ExerciseModel>(filteredExerciseList);
        }

        private string _exerciseDescription;

        public string ExerciseDescription
        {
            get { return _exerciseDescription; }
            set 
            {
                _exerciseDescription = value;
                NotifyOfPropertyChange(() => ExerciseDescription);
            }
        }

        private string _exercisePicture;

        public string ExercisePicture
        {
            get { return _exercisePicture; }
            set 
            { 
                _exercisePicture = value;
                NotifyOfPropertyChange(() => ExercisePicture);
            }
        }


        public string GetExercisePicture()
        {
            if (SelectedExercise != null)
            {
                ExercisePictureModel exercisePicture = _exerciseList.GetPictures().Where(x => x.ExerciseId == SelectedExercise.Id)
                .FirstOrDefault();

                string exercisePicturePath = exercisePicture?.ExercisePicturePath;
                return exercisePicturePath;
            }
            else
            {
                return "";
            }

        }
    }
}
