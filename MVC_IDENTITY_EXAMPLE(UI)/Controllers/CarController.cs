using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Domain.Model;
using Microsoft.AspNetCore.Authorization;
using BLL.Service;
using BLL.Dto;

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
            var cars = new List<CarDto>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new CarDto()
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

        
        [HttpGet]
        public async Task<ActionResult> Create() => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> Create(CarDto car)
        {
            await _carService.AddCarAsync(car);
            return RedirectToAction(nameof(Index));
        }

    }
}
