using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Dto;
using BLL.Service;
using BLL.Service.Interfaces;
using Core.Context;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace BLL.Service
{
    // todo Create methods to work with cars
    public class CarService : ICarService
    {
        private readonly CarContext _carContext;
        private readonly IMapper _mapper;
        public CarService(CarContext carContext, IMapper mapper)
        {
            this._carContext = carContext;
            this._mapper = mapper;
        }

        public Task AddCarAsync(CarDto carDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarDto>> GetAllCarsAsync()
        {
            var cars = await _carContext.Cars.ToListAsync();
            var carsDto = _mapper.Map<List<CarDto>>(cars);
            return carsDto;
        }

        public async Task<CarDto> GetCarAsync(int Id)
        {
            var car = await _carContext.Cars.FindAsync(Id);
            var carDto = _mapper.Map<CarDto>(car);
            return carDto;
        }
    }
}
