using FirstTask.Car.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Car.Controllers
{
    public class CarsController : Controller
    {
        private readonly List<Cars> _Cars;

        public CarsController()
        {
            _Cars = new List<Cars>
            {
                new Cars { Id=1, Models= "e-tron", Years = 2005, GroupId=1},
                new Cars { Id=2, Models= "M5 E60", Years = 2000, GroupId=2},
                new Cars { Id=3, Models= "E63", Years = 2021, GroupId=3},
                new Cars { Id=4, Models= "Charger", Years = 1970, GroupId=4},
            };
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_Cars);
            }
            if (_Cars.Exists(s => s.GroupId == id))
            {
                return View(_Cars.FindAll(s => s.GroupId == id));
            }
            else
            {
                return NotFound();
            }


            return View();
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_Cars.Exists(s => s.Id == id))
            {
                return View(_Cars.Find(s => s.Id == id));
            }
            else
            {
                return NotFound();
            }
        }
    }
}