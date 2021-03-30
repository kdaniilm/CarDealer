using BLL.Dto;
using BLL.Service;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.Interfaces
{
    public interface ICarService
    {
        Task AddCarAsync(Car car);
        Task<List<Car>> GetAllCarsAsync();
        Task<CarDto> GetCarAsync(int Id);
    }
}
