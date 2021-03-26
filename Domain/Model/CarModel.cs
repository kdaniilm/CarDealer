using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CarModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public CarBrend Brend { get; set; }
    }
}
