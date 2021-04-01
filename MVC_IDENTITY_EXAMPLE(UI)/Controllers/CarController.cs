using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BLL.Service;
using BLL.Dto;
using MVC_IDENTITY_EXAMPLE_UI_.Models;
using AutoMapper;
using Domain.Model;

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

        public async Task<ActionResult> GetCarPartialAsync(FilterViewModel filter)
        {
            var filterDto = _mapper.Map<FilterDto>(filter);
            var cars = await _carService.GetCarsWithFilterAsync(filterDto);
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
        public async Task<ActionResult> Create(CarViewModel carVM, string isNewCheckBoxAnswer)
        {
            if (ModelState.IsValid)
            {
                var car = _mapper.Map<Car>(carVM);
                await _carService.AddCarAsync(car);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
