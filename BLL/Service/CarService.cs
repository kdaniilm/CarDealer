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

        public async Task AddCarAsync(CarDto carDto)
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
            #endregion
            var car = await CarConfigureAsync(carDto);
            await _carContext.Cars.AddAsync(car);
            await _carContext.SaveChangesAsync();
        }

        private async Task<Car> CarConfigureAsync(CarDto carDto)
        {
            var car = new Car();

            car.CarPrice = carDto.CarPrice;
            car.RunRange = carDto.RunRange;
            car.IsNew = carDto.IsNew;

            car.Model = new CarModel() { Brend = new CarBrend() { CreateCountry = new CreateCountry() { CountryName = "Germany" }, BrendName = carDto.Brend }, ModelName = carDto.Model };

            var imagePathes = new List<ImagePath>();
            foreach(var img in carDto.ImagePathes)
            {
                imagePathes.Add(new ImagePath() { ImgPath = img});
            }
            imagePathes.Add(new ImagePath() { ImgPath = "asd" });
            car.ImagePathes = imagePathes;

            var comfortList = new List<ComfortConfiguration>();
            foreach (var comfortItem in carDto.ComfortList)
            {
                comfortList.Add( await _carContext.ComfortConfigurations.FindAsync(comfortItem));
            }
            car.ComfortList = comfortList;

            var stateList = new List<StateConfiguration>();
            foreach (var stateItem in carDto.StateList)
            {
                stateList.Add(await _carContext.StateConfigurations.FindAsync(stateItem));
            }
            car.StateList = stateList;

            var multiMediaList = new List<MultiMediaConfiguration>();
            foreach (var multiMediaItem in carDto.MultiMediaList)
            {
                multiMediaList.Add(await _carContext.MultiMediaConfigurations.FindAsync(multiMediaItem));
            }
            car.MultiMediaList = multiMediaList;

            var saveList = new List<SaveConfiguration>();
            foreach (var saveItem in carDto.SaveList)
            {
                saveList.Add(await _carContext.SaveConfigurations.FindAsync(saveItem));
            }
            car.SaveList = saveList;

            var baseConfig = new BaseConfiguration();
            baseConfig.BodyType = carDto.BodyType;
            baseConfig.DoorsCount = carDto.DoorsCount;
            baseConfig.DriverianType = carDto.DriverianType;
            baseConfig.GearBoxType = carDto.GearBoxType;
            baseConfig.GearCount = carDto.GearCount;
            baseConfig.Engine = new Engine() {
                CylinderCount = carDto.CylinderCount,
                Petrol = await _carContext.PetrolTypes.FindAsync(carDto.PetrolTypeId),
                Volume = carDto.Volume,
                Characteristics = new EngineCharacteristics()
                {
                    MaxPower = carDto.MaxPower,
                    MaxTorque = carDto.MaxTorque,
                    MaxRpm = carDto.MaxRpm,
                    MaxPowerRpm = carDto.MaxPowerRpm,
                    MaxTorqueRpm = carDto.MaxTorqueRpm,
                    CityСonsumption = carDto.CityСonsumption,
                    AutobanСonsumption = carDto.AutobanСonsumption,
                    MidleСonsumption = carDto.MidleСonsumption,
                    Boost = await _carContext.BoostTypes.FindAsync(carDto.BoostTypeId)
                }
            };

            car.Base = baseConfig;

            car.Comments = new List<Comment>();

            return car;
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            var cars = await _carContext.Cars.Include(x => x.Model).Include(x => x.Model.Brend).Include(x => x.Base).Include(x => x.Base.Engine)
                .Include(x => x.Base.Engine.Petrol).ToListAsync();
            return cars;
        }

        public async Task<CarDto> GetCarAsync(int Id)
        {
            var car = await _carContext.Cars.FindAsync(Id);
            var carDto = _mapper.Map<CarDto>(car);
            return carDto;
        }
    }
}
