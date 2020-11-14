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

        public static WorkoutViewModel Create(Workout workout) {
            return new WorkoutViewModel {
                Workout = workout
            };
        }

        public static WorkoutViewModel Edit(Workout workout) {
            return new WorkoutViewModel {
                Workout = workout,
                Action = "Edit"
            };
        }

        public static WorkoutViewModel Delete(Workout workout) {
            return new WorkoutViewModel {
                Workout = workout,
                Action = "Delete",
                ReadOnly = true
            };
        }
    }
}