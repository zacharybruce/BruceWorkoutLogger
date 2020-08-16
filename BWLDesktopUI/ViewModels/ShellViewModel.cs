using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BWLDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private WorkoutLogViewModel _workoutLogVM;

        public ShellViewModel(WorkoutLogViewModel workoutLogVM)
        {
            _workoutLogVM = workoutLogVM;
            ActivateItem(_workoutLogVM);
        }

        public void WorkoutHistory()
        {
            ActivateItem(IoC.Get<WorkoutHistoryViewModel>());
            Application.Current.MainWindow.Height = 500;
            Application.Current.MainWindow.Width = 800;
        }

        public void WorkoutLog()
        {
            ActivateItem(IoC.Get<WorkoutLogViewModel>());
            Application.Current.MainWindow.Height = 500;
            Application.Current.MainWindow.Width = 800;
        }

        public void ExerciseList()
        {
            ActivateItem(IoC.Get<ExerciseListViewModel>());
            Application.Current.MainWindow.Height = 500;
            Application.Current.MainWindow.Width = 800;
        }

        public void ExerciseDescriptions()
        {
            ActivateItem(IoC.Get<ExerciseDescriptionViewModel>());
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 1000;
        }
    }
}
