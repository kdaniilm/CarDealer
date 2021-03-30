using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BLL.Service;
using BLL.Dto;
using MVC_IDENTITY_EXAMPLE_UI_.Models;
using AutoMapper;

namespace MVC_IDENTITY_EXAMPLE_UI_.Controllers
{
    //[Authorize]
    public class CarController : Controller
    {
        private readonly CarService _carService;
        private readonly IMapper _mapper;

        public CarController(CarService carService, IMapper mapper)
        {
            this._carService = carService;
            this._mapper = mapper;
        }

        public async Task<ActionResult> GetCarPartial()
        {
            var cars = await _carService.GetAllCarsAsync();
            return PartialView("GetCarPartial", cars);
        }
        public async Task<ActionResult> Index()
        {
            return await Task.Run(() => View());
        }
        [HttpGet]
        public async Task<ActionResult> Create() => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> Create(CarViewModel car, string isNewCheckBoxAnswer)
        {
            if (isNewCheckBoxAnswer == "on")
                car.IsNew = true;
            else
                car.IsNew = false;

            var carDto = _mapper.Map<CarDto>(car);
            var x = "";
            foreach(var item in ModelState.Values)
            {
                foreach (var item2 in item.Errors)
                {
                    x = item2.ToString();  
                }
            }
            if (ModelState.IsValid)
            {
                await _carService.AddCarAsync(carDto);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
