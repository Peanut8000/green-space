using Microsoft.AspNetCore.Mvc;

namespace green_space.Controllers
{
    public class MapsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
