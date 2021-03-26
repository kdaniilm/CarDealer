using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Context;
using Domain.Model;

namespace BLL
{
    // todo Create methods to work with cars
    public class CarService
    {
        private readonly CarContext _carContext;

        public CarService(CarContext carContext)
        {
            this._carContext = carContext;
        }

        //public IList<Book> GetBooks() => _bookContext.Books.ToList();

        //public void Add(Book book)
        //{
        //    _bookContext.Books.Add(book);
        //    _bookContext.SaveChanges();
        //}
    }
}
