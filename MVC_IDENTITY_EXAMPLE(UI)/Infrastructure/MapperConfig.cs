using AutoMapper;
using BLL.Dto;
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
            CreateMap<CarDto, CarViewModel>();
            CreateMap<CarViewModel, CarDto>();
        }
    }
}
