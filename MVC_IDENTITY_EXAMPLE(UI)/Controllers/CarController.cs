using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Domain.Model;
using Microsoft.AspNetCore.Authorization;

namespace MVC_IDENTITY_EXAMPLE_UI_.Controllers
{
    //[Authorize]
    public class CarController : Controller
    {
        // GET: BookController
        private readonly CarService _carService;

        public CarController(CarService carService)
        {
            this._carService = carService;
        }
        public ActionResult Index()
        {
            //return View(_bookService.GetBooks());
            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car()
                {
                    ImagePathes = new List<ImagePath> { new ImagePath() { ImgPath = "asd" } },
                    Model = new CarModel() { Brend = new CarBrend() { BrendName = "Nissan" }, ModelName = "Juke" },
                    CarPrice = 2000,
                    RunRange = 100000,
                    Base = new BaseConfiguration() { Engine = new Engine() { Petrol = new PetrolType() { Type = "Petrol" }, Volume = 1593 }, GearBoxType = "Manual", DriverianType = "FWD" }
                });
            }
            return View(cars);
        }

        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public ActionResult Create(Book book)
        {
            //_bookService.Add(book);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Create() => View();


    }
}
