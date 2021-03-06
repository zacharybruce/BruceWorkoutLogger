﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLData.Library.Models
{
    public class WorkoutDetailModel
    {
        public int Id { get; set; }
        public string WorkoutName { get; set; }
        public DateTime DateOfWorkout { get; set; }

        public string DisplayText
        {
            get
            {
                return $"{ DateOfWorkout.ToShortDateString() }: { WorkoutName }";
            }
        }
    }
}
