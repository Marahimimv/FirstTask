using FirstTask.Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Car.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Group> groups = new List<Group>
            {
                new Group { Id = 1, No = "Audi" },
                new Group { Id = 2, No = "BMW" },
                new Group { Id = 3, No = "Mercedes" },
                new Group { Id = 4, No = "Dodge" },
            };

            return View(groups);
        }
    }
}