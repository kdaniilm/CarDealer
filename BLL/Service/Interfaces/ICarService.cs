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
        Task AddCarAsync(Car car, User user);
        Task<List<Car>> GetAllCarsAsync(FilterDto filter);
        Task<Car> GetCarAsync(int Id);
        //Task<List<Car>> GetCarsWithFilterAsync(FilterDto filter);
    }
}
