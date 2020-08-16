using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWLData.Library.Models
{
    public class ExercisePictureModel
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public string ExercisePicturePath { get; set; }
    }
}
