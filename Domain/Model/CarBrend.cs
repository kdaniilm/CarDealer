using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CarBrend
    {
        public int Id { get; set; }
        public string BrendName { get; set; }
        public CreateCountry CreateCountry { get; set; }
    }
}
