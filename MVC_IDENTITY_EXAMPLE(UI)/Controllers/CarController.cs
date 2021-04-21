using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BLL.Service;
using BLL.Dto;
using MVC_IDENTITY_EXAMPLE_UI_.Models;
using AutoMapper;
using Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System;

namespace MVC_IDENTITY_EXAMPLE_UI_.Controllers
{
    public class CarController : Controller
    {
        private readonly CarService _carService;
        private readonly IMapper _mapper;

        public CarController(CarService carService, IMapper mapper)
        {
            this._carService = carService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> BiggestSearch() => await Task.Run(() => View());

        [HttpPost]
        public async Task<ActionResult> GetCarPartialAsync(FilterViewModel filter)
        {
            var filterDto = _mapper.Map<FilterDto>(filter);
            var cars = await _carService.GetAllCarsAsync(filterDto);
            return PartialView("GetCarPartial", cars);
        }
        [HttpGet]
        public async Task<ActionResult> Index() =>  await Task.Run(() => View());

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Create() => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> Create(CarViewModel carVM)
        {
            if (ModelState.IsValid)
            {
                var car = _mapper.Map<Car>(carVM);
                var user = new User() { UserName = User.Identity.Name};
                await _carService.AddCarAsync(car, user);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
