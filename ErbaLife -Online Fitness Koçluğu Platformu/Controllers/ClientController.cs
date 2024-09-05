using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Client")]
    public class ClientController : Controller
    {
        public IActionResult ViewProfile()
        {
            // Implement view profile logic here
            return View();
        }

        public IActionResult ViewExercisePlans()
        {
            // Implement view exercise plans logic here
            return View();
        }

        public IActionResult ViewNutritionPlans()
        {
            // Implement view nutrition plans logic here
            return View();
        }

        public IActionResult ViewProgress()
        {
            // Implement view progress logic here
            return View();
        }
    }
}
