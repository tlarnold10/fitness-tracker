using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models {

    public static class SeedData {
        public static void EnsurePopulated(IApplicationBuilder app) {
            FitnessTrackerDbContext context = app.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<FitnessTrackerDbContext>();
            
            DateTime today = DateTime.Today;
            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Workouts.Any()) {
                context.Workouts.AddRange(
                    new Workout {
                        Lift="Dumbell Front Squat",
                        Reps=18,
                        Weight=52,
                        WorkoutDate=today
                    },
                    new Workout {
                        Lift="Power Clean",
                        Reps=8,
                        Weight=52,
                        WorkoutDate=today
                    },
                    new Workout {
                        Lift="Lunge",
                        Reps=12,
                        Weight=80
                    },
                    new Workout {
                        Lift="Romanian Deadlift",
                        Reps=10,
                        Weight=104
                    },
                    new Workout {
                        Lift="Calves",
                        Reps=20,
                        Weight=104
                    },
                    new Workout {
                        Lift="Dumbell Front Squat",
                        Reps=16,
                        Weight=52
                    },
                    new Workout {
                        Lift="Dumbell Front Squat",
                        Reps=16,
                        Weight=52
                    }
                );
                context.SaveChanges();
            }
        }
    }
}