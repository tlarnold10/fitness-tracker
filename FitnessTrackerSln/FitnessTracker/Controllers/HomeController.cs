using Microsoft.AspNetCore.Mvc;
using FitnessTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FitnessTracker.Controllers {
    public class HomeController: Controller {
        private FitnessTrackerDbContext repository;

        public HomeController(FitnessTrackerDbContext context) {
            repository = context;
        }

        public IActionResult Index() => View(repository.Workouts);

        public async Task<IActionResult> Details(long id) {
            Workout w = await repository.Workouts.FirstOrDefaultAsync(w => w.WorkoutID == id);
            WorkoutViewModel model = ViewModelFactory.Details(w);
            return View("WorkoutEditor", model);
        }

        public IActionResult Create() {
            return View("WorkoutEditor", ViewModelFactory.Create(new Workout()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Workout workout) {
            if(ModelState.IsValid) {
                workout.WorkoutID = default;
                repository.Workouts.Add(workout);
                await repository.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("WorkoutEditor", ViewModelFactory.Create(workout));
        }
    }
}