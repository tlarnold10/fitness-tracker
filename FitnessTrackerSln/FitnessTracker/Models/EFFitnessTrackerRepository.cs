using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models {
    public class EFFitnessTrackerRepository : IFitnessTrackerRepository {
        private FitnessTrackerDbContext context;

        public EFFitnessTrackerRepository(FitnessTrackerDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Workout> Workouts => context.Workouts;

        public void Save() {
            SaveChanges();
        }
    }
}