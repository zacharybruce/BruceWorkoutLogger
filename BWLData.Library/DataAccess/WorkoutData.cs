﻿using BWLData.Library.Internal.DataAccess;
using BWLData.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLData.Library.DataAccess
{
    public class WorkoutData
    {
        public List<WorkoutModel> GetAllWorkouts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var output = sql.LoadData<WorkoutModel, dynamic>("dbo.spWorkout_GetAll", new { }, "BWLData");

            return output;
        }
    }
}