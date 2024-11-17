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

        // Action to display the list of species groups
        public IActionResult SpeciesGroups()
        {
            var speciesGroups = _context.ConservationStatuses.ToList();
            return View(speciesGroups);
        }

        // Action to display detailed information for a specific species group
        public IActionResult Details(int id)
        {
            var speciesGroup = _context.ConservationStatuses
                .FirstOrDefault(s => s.status_id == id);

            if (speciesGroup == null)
            {
                return NotFound();
            }

            return View(speciesGroup);
        }
    }
}
