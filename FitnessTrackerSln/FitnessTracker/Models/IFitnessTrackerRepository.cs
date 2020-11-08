using System.Linq;

namespace FitnessTracker.Models {
    public interface IFitnessTrackerRepository {
        IQueryable<Workout> Workouts {get; }
    }
}