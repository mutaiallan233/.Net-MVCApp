
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();
        public IActionResult Index()
        {
            /*DogViewModel doggo = new DogViewModel()
            {
                Name = "Shifu",
                Age = 21,
            };
            return View(doggo);*/
            return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //return View("index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }
}
