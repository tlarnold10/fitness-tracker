using System.Linq;

namespace FitnessTracker.Models {
    public class EFFitnessTrackerRepository : IFitnessTrackerRepository {
        private FitnessTrackerDbContext context;

        public EFFitnessTrackerRepository(FitnessTrackerDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Workout> Workouts => context.Workouts;
    }
}