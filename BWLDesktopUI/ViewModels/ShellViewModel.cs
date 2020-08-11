using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void WorkoutLog()
        {
            ActivateItem(IoC.Get<WorkoutLogViewModel>());
        }
    }
}
