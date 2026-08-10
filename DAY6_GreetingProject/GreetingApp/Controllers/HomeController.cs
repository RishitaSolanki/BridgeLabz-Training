using Microsoft.AspNetCore.Mvc;
using GreetingApp.Models;

namespace GreetingApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly NameRepository repository;


        // Constructor
        public HomeController()
        {
            repository = new NameRepository();
        }



        // Open View Page
        public IActionResult Index()
        {
            return View();
        }




        // Save Name API
        [HttpPost]
        public IActionResult SaveName([FromBody] NameModel model)
        {

            Console.WriteLine("Received Name: " + model.Name);


            // Validation Logic
            if (string.IsNullOrEmpty(model.Name))
            {
                return Json(new
                {
                    message = "Please enter your name"
                });
            }



            // Calling Repository Layer
            repository.SaveName(model.Name);



            return Json(new
            {
                message = "Name saved successfully"
            });

        }





        // Submit API
        [HttpGet]
        public IActionResult Submit()
        {

            string? name = repository.GetName();



            if (string.IsNullOrEmpty(name))
            {
                return Json(new
                {
                    message = "Please save your name first"
                });
            }



            return Json(new
            {
                message = "Welcome " + name
            });

        }

    }
}