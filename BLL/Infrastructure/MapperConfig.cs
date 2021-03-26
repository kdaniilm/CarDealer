using AutoMapper;
using BLL.Dto;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CarDto, Car>();
        }
    }
}
