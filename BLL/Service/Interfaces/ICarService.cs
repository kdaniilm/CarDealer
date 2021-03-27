using BLL.Dto;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface ICarService
    {
        Task AddCarAsync(CarDto carDto);
        Task<List<CarDto>> GetAllCarsAsync();
        Task<CarDto> GetCarAsync(int Id);
    }
}
