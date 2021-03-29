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


        public async Task<ActionResult> Index()
        {
            var cars = await _carService.GetAllCarsAsync();
            return View(cars);
        }
        [HttpGet]
        public async Task<ActionResult> Create() => await Task.Run(() => View());

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> Create(CarViewModel car)
        {
            var carDto = _mapper.Map<CarDto>(car);
            if (ModelState.IsValid)
            {
                await _carService.AddCarAsync(carDto);
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
