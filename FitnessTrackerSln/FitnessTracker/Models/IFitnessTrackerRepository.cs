using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models {
    public interface IFitnessTrackerRepository {
        IQueryable<Workout> Workouts {get; }
    }
}