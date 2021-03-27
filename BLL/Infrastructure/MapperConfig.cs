using AutoMapper;
using BLL.Service;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Dto;

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
