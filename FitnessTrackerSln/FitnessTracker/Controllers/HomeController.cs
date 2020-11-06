using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers {
    public class HomeController: Controller {
        public IActionResult Index() => View();
    }
}