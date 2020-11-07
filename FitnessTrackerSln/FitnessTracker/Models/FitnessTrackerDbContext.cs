using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models {
    public class FitnessTrackerDbContext: DbContext {

        public FitnessTrackerDbContext(DbContextOptions<FitnessTrackerDbContext> options)
            : base(options) { }

        public DbSet<Workout> Workouts {get; set; }
    }
}