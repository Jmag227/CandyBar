using Microsoft.AspNetCore.Mvc;
using CandyBarProject;

namespace CandyBarProject.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandy repo;
        
        public CandyController(ICandy repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var candy = repo.GetAllInfo();
            return View(candy);
        }

        public IActionResult ViewCandy(int id)
        {
            var candy = repo.GetCandy(id);
            return View(candy);
        }

        public IActionResult UpdateCandy(int id)
        {
            Candy can = repo.GetCandy(id);
            if (can == null)
            {
                return View("CandyNotFound");
            }
            else
            {
                return View(can);
            }            
        }

        public IActionResult UpdateDatabase(Candy candy)
        {
            repo.UpdateCandy(candy);
            return RedirectToAction("ViewCandy", new { id = candy.Dbid });
        }

        public IActionResult InsertCandy()
        {
            var newCandy = new Candy();
            
            return View(newCandy);
        }

        public IActionResult InsertCandyToDatabase(Candy candy)
        {
            repo.InsertCandy(candy);

            return RedirectToAction("Index");
        }

        public IActionResult DeleteCandy(Candy candy)
        {
            repo.DeleteCandy(candy);

            return RedirectToAction("Index");
        }
    }
}
