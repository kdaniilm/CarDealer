using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Engine
    {
        public int Id { get; set; }
        public decimal? Volume { get; set; }
        public int CylinderCount { get; set; }
        public string PetrolType { get; set; }
        //public EngineCharacteristics Characteristics { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public int MaxRpm { get; set; }
        public int MaxPowerRpm { get; set; }
        public int MaxTorqueRpm { get; set; }
        public decimal CityСonsumption { get; set; }
        public decimal AutobanСonsumption { get; set; }
        public decimal MidleСonsumption { get; set; }
        public string BoostType { get; set; }
    }
}
