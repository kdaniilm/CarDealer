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

        public async Task AddCarAsync(Car car, User user)
        {
            await _carContext.Cars.AddAsync(car);
            await _carContext.SaveChangesAsync();
            var userCarBuff = new UserCarBuff() { Car = car, CarOvner = user };
            await _carContext.UserCarBuffs.AddAsync(userCarBuff);
            await _carContext.SaveChangesAsync();
        }
        public async Task<Car> GetCarAsync(int Id)
        {
            var car = await _carContext.Cars.FindAsync(Id);
            return car;
        }
        public async Task<List<Car>> GetAllCarsAsync(FilterDto filter)
        {
            var car = _carContext.Cars.Include(x => x.Engine);
            if (filter.IsNew != null)
                car = car.Where(x => x.IsNew == filter.IsNew).Include(x => x.Engine);

            if (filter.BodyType != "All")
                car = car.Where(x => x.BodyType == filter.BodyType).Include(x => x.Engine);


            var res = await car.ToListAsync();
            return await Task<Car>.Run(() => res);
        }
    }
}
