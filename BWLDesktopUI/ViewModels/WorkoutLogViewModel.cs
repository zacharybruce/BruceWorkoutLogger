﻿using BWLDesktopUI.DataAccess;
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
        List<WorkoutModel> workouts = new List<WorkoutModel>();

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

        private WorkoutModel _selectedWorkout;

        public WorkoutModel SelectedWorkout
        {
            get { return _selectedWorkout; }
            set 
            {
                _selectedWorkout = value;
                NotifyOfPropertyChange(() => SelectedWorkout);
                NotifyOfPropertyChange(() => CanAddWorkout);
            }
        }

        private string _workoutDate;

        public string WorkoutDate
        {
            get { return _workoutDate; }
            set 
            {
                _workoutDate = value;
                NotifyOfPropertyChange(() => WorkoutDate);
                NotifyOfPropertyChange(() => CanAddWorkout);
            }
        }

        public void AddWorkout()
        {
            WorkoutModel selectedWorkout = SelectedWorkout;
            workouts.Add(selectedWorkout);
            NotifyOfPropertyChange(() => CanAddWorkout);
        }


        public bool CanAddWorkout
        {
            get 
            {
                bool output = false;

                if ((DateTime.TryParse(WorkoutDate, out DateTime date) == true) && (SelectedWorkout?.WorkoutName.Length > 0))
                {
                    output = true;
                }

                return output;
            }
        }


    }
}
