using AutoMapper;
using BLL.Dto;
using Domain.Model;
using MVC_IDENTITY_EXAMPLE_UI_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Infrastructure
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Car, CarViewModel>();
            CreateMap<CarViewModel, Car>().ForMember(x => x.Engine, opt => opt.MapFrom(src => new Engine() {
                AutobanСonsumption = src.AutobanСonsumption,
                BoostType = src.BoostType,
                CityСonsumption = src.CityСonsumption,
                CylinderCount = src.CylinderCount,
                MaxPower = src.MaxPower,
                MaxPowerRpm = src.MaxPowerRpm,
                MaxRpm = src.MaxRpm,
                MaxTorque = src.MaxTorque,
                MaxTorqueRpm = src.MaxTorqueRpm, MidleСonsumption = src.MidleСonsumption,
                PetrolType = src.PetrolType,
                Volume = src.Volume
            }));
        }
    }
}
