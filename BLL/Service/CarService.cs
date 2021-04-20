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

        public async Task AddCarAsync(Car car)
        {
            #region old method
            //var createCountry = new CreateCountry() { CountryName = "Japan" };

            //var carBrend = new CarBrend() { CreateCountry = createCountry, BrendName = carDto.BrendName };

            //var carModel = new CarModel() { Brend = carBrend, ModelName = carDto.ModelName};

            //var imgPathes = new List<ImagePath>();
            //foreach(var img in carDto.ImagePathes)
            //{
            //    imgPathes.Add(new ImagePath() { ImgPath = img});
            //}

            //var comfortConfig = new List<ComfortConfiguration>();
            //foreach(var comfortItem in carDto.ComfortConfigName)
            //{
            //    comfortConfig.Add(new ComfortConfiguration() { ConfigName = comfortItem});
            //}

            //var stateConfig = new List<StateConfiguration>();
            //foreach (var stateItem in carDto.StateConfigName)
            //{
            //    stateConfig.Add(new StateConfiguration() { ConfigName = stateItem });
            //}

            //var multiMediaConfig = new List<MultiMediaConfiguration>();
            //foreach (var multiMediaItem in carDto.MultiMediaConfigName)
            //{
            //    multiMediaConfig.Add(new MultiMediaConfiguration() { ConfigName = multiMediaItem });
            //}

            //var saveConfig = new List<SaveConfiguration>();
            //foreach (var saveItem in carDto.SaveConfigName)
            //{
            //    saveConfig.Add(new SaveConfiguration() { ConfigName = saveItem });
            //}

            //var boost = new BoostType() { Type = carDto.Boost };

            //var engineCharacteristics = new EngineCharacteristics()
            //{
            //    MaxPower = carDto.MaxPower,
            //    MaxTorque = carDto.MaxTorque,
            //    MaxRpm = carDto.MaxRpm,
            //    MaxPowerRpm = carDto.MaxPowerRpm,
            //    MaxTorqueRpm = carDto.MaxTorqueRpm,
            //    CityСonsumption = carDto.CityСonsumption,
            //    AutobanСonsumption = carDto.AutobanСonsumption,
            //    MidleСonsumption = carDto.MidleСonsumption,
            //    Boost = boost
            //};

            //var petrol = new PetrolType() { Type = carDto.PetrolType };

            //var engine = new Engine()
            //{
            //    Volume = carDto.Volume,
            //    CylinderCount = carDto.CylinderCount,
            //    Petrol = petrol,
            //    Characteristics = engineCharacteristics
            //};

            //var baseConfig = new BaseConfiguration()
            //{
            //    GearBoxType = carDto.GearBoxType,
            //    GearCount = carDto.GearCount,
            //    DriverianType = carDto.DriverianType,
            //    DoorsCount = carDto.DoorsCount,
            //    BodyType = carDto.BodyType,
            //    Engine = engine
            //};
            //var car = new Car()
            //{
            //    IsNew = carDto.IsNew,
            //    CarPrice = carDto.CarPrice,
            //    RunRange = carDto.RunRange,
            //    Model = carModel,
            //    ImagePathes = imgPathes,
            //    ComfortList = comfortConfig,
            //    StateList = stateConfig,
            //    MultiMediaList = multiMediaConfig,
            //    SaveList = saveConfig,
            //    Base = baseConfig,
            //    Comments = null
            //};
            #endregion //await CarConfigureAsync(carDto);
            await _carContext.Cars.AddAsync(car);
            await _carContext.SaveChangesAsync();
        }
        //public async Task<List<Car>> GetAllCarsAsync()
        //{
        //    var cars = await _carContext.Cars.Include(x => x.Engine).ToListAsync();
        //    return cars;
        //}

        public async Task<Car> GetCarAsync(int Id)
        {
            var car = await _carContext.Cars.FindAsync(Id);
            return car;
        }
        public async Task<List<Car>> GetCarsWithFilterAsync(FilterDto filter)
        {
<<<<<<< Updated upstream
            var car = await _carContext.Cars.Include(x => x.Engine).Where(x => x.IsNew == filter.IsNew).ToListAsync();
=======
            var car = new List<Car>();
            if (filter.IsNew != null)
                car = await _carContext.Cars.Include(x => x.Engine).Where(x => x.IsNew == filter.IsNew).ToListAsync();
            else
                car = await _carContext.Cars.Include(x => x.Engine).ToListAsync();

>>>>>>> Stashed changes
            return await Task<Car>.Run(() => car);
        }
    }
}
