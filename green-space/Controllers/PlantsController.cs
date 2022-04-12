using green_space.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var plants = _context.Plants.Include("Family").ToList();
            return View(plants);
        }

        // GET: /<controller>/details/{id}
        public IActionResult Details(int id)
        {
            var plant = _context.Plants.Include("Family").Where(p => p.Id == id).FirstOrDefault(); ;
            return View(plant);
        }

    }
}

