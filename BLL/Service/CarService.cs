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
            var car = _carContext.Cars.Include(x => x.Engine).Where(x => x.Id > 0);
            if (filter.IsNew != null)
                car = car.Where(x => x.IsNew == filter.IsNew);
            if (filter.MinPrice != 0)
                car = car.Where(x => x.CarPrice >= filter.MinPrice);
            if(filter.MaxPrice != 0)
                car = car.Where(x => x.CarPrice <= filter.MaxPrice);
            if (filter.MinRange != 0)
                car = car.Where(x => x.RunRange >= filter.MinRange);
            if (filter.MaxRange != 0)
                car = car.Where(x => x.RunRange <= filter.MaxRange);
            if (filter.CreateCountryName != "null" && filter.CreateCountryName != null) 
                car = car.Where(x => x.CreateCountryName == filter.CreateCountryName);
            if (filter.BrendName != "null" && filter.BrendName != null)
                car = car.Where(x => x.CarBrend == filter.BrendName);
            if (filter.ModelName != "null" && filter.ModelName != null)
                car = car.Where(x => x.ModelName == filter.ModelName);
            if (filter.GearBoxType != "null" && filter.GearBoxType != null)
                car = car.Where(x => x.GearBoxType == filter.GearBoxType);
            if (filter.DriverianType != "null" && filter.DriverianType != null)
                car = car.Where(x => x.DriverianType == filter.DriverianType);
            if (filter.PetrolType != "null" && filter.PetrolType != null)
                car = car.Where(x => x.Engine.PetrolType == filter.PetrolType);
            if (filter.BodyType != "null" && filter.BodyType != null)
                car = car.Where(x => x.BodyType == filter.BodyType);
            if (filter.DoorsCount != 0)
                car = car.Where(x => x.DoorsCount == filter.DoorsCount);
            if (filter.CityСonsumption != 0)
                car = car.Where(x => x.Engine.CityСonsumption == filter.CityСonsumption);
            if (filter.AutobanСonsumption != 0)
                car = car.Where(x => x.Engine.AutobanСonsumption == filter.AutobanСonsumption);
            if (filter.MidleСonsumption != 0)
                car = car.Where(x => x.Engine.MidleСonsumption == filter.MidleСonsumption);
            if (filter.MaxPower != 0)
                car = car.Where(x => x.Engine.MaxPower == filter.MaxPower);
            if(filter.MaxTorque != 0)
                car = car.Where(x => x.Engine.MaxTorque == filter.MaxTorque);
            if (filter.MinYear != 0)
                car = car.Where(x => x.ProductionYear >= filter.MinYear);
            if (filter.MaxYear != 0)
                car = car.Where(x => x.ProductionYear <= filter.MaxYear);

            //ConfigurationFilter start
            car = car.Where(x => x.IsHaveCondicioner == filter.IsHaveCondicioner && x.IsHaveSeatsHeating == filter.IsHaveSeatsHeating
                    && x.IsHaveCruiseControl == filter.IsHaveCruiseControl && x.IsHaveGarageSaving == filter.IsHaveGarageSaving && x.IsHaveDontHit == filter.IsHaveDontHit
                    && x.IsHaveFirstOwner == filter.IsHaveFirstOwner && x.IsHaveMp3 == filter.IsHaveMp3 && x.IsHaveSubbufer == filter.IsHaveSubbufer && x.IsHaveAirBags == filter.IsHaveAirBags
                    && x.IsHaveSleepingCheck == filter.IsHaveSleepingCheck);
            //ConfigurationFilter End


            var res = await car.ToListAsync();
            return await Task<Car>.Run(() => res);
        }
    }
}
