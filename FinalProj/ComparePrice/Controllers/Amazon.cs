using Microsoft.AspNetCore.Mvc;

namespace ComparePrice.Controllers
{
    public class Amazon : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
