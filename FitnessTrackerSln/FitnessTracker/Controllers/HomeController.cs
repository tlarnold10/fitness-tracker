using Microsoft.AspNetCore.Mvc;
using FitnessTracker.Models;

namespace FitnessTracker.Controllers {
    public class HomeController: Controller {
        private IFitnessTrackerRepository repository;

        public HomeController(IFitnessTrackerRepository repo) {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Workouts);
    }
}