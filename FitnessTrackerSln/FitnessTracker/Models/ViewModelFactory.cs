using System.Collections.Generic;
using System.Linq;

namespace FitnessTracker.Models {
    public static class ViewModelFactory {
        public static WorkoutViewModel Details(Workout w) {
            return new WorkoutViewModel {
                Workout = w, Action = "Details",
                ReadOnly = true, ShowAction = false
            };
        }
    }
}