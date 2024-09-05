using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Authorize(Roles = "Coach")]
    public class CoachController : Controller
    {
        public IActionResult ManageClients()
        {
            // Implement client management logic here
            return View();
        }

        public IActionResult CreateExercisePlan()
        {
            // Implement create exercise plan logic here
            return View();
        }

        public IActionResult CreateNutritionPlan()
        {
            // Implement create nutrition plan logic here
            return View();
        }

        public IActionResult ViewProgress()
        {
            // Implement view progress logic here
            return View();
        }
    }
}
