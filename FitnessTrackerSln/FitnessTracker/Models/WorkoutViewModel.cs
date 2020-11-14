using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Models {
    public class WorkoutViewModel {
        public Workout Workout {get; set; }
        public string Action {get; set; } = "Create";
        public bool ReadOnly {get; set; } = false;
        public bool ShowAction {get; set; } = true;
    }
}