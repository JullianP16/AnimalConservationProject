using Microsoft.AspNetCore.Mvc;

namespace AnimalConservationWebsite.Controllers
{
    public class ConservationController : Controller
    {
        // Action method for the Conservation Efforts page
        public IActionResult Efforts()
        {
            return View();
        }
    }
}
