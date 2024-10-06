using Microsoft.AspNetCore.Mvc;
using AnimalConservationWebsite.Data;  
using System.Linq;
using AnimalConservationWebsite.Models;

namespace AnimalConservationWebsite.Controllers
{
    public class SpeciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpeciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult SpeciesGroups()
        {
            var speciesGroups = _context.ConservationStatuses.ToList();
            return View(speciesGroups);
        }


    }
}
