using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class BaseConfiguration
    {
        public int Id { get; set; }
        public string GearBoxType { get; set; }
        public int GearCount { get; set; }
        public string DriverianType { get; set; }
        public int DoorsCount { get; set; }
        public string BodyType { get; set; }
        public Engine Engine { get; set; }
    }
}
