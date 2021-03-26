using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ShowContacts
    {
        public int Id { get; set; }
        public Car CurrentCar { get; set; }
        public int LookCount { get; set; }
    }
}
