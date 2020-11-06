using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace FitnessTracker.Models {
    public class Workout {
        public long WorkoutID {get; set; }
        
        public string Lift {get; set; }
        
        public int Reps {get; set; }
        
        public int Weight {get; set; }
        
        [DataType(DataType.Date)]
        public DateTime WorkoutDate { get; set; }
    }
}