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
        public PetrolType Petrol { get; set; }
        public EngineCharacteristics Characteristics { get; set; }
    }
}
