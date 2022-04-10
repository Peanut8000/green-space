using green_space.Data;
using Microsoft.AspNetCore.Mvc;

namespace green_space.Controllers
{
    public class PlantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var plants = _context.Plants.ToList();
            return View(plants);
        }

        // GET: /<controller>/details/{id}
        public IActionResult Details(int id)
        {
            var plant = _context.Plants.Where(p => p.Id == id).FirstOrDefault();
            return View(plant);
        }

    }
}

