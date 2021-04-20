using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Models
{
    public class FilterViewModel
    {
        public bool? IsNew { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public string CreateCountryName { get; set; }
        public string BrendName { get; set; }
        public string ModelName { get; set; }
        public string GearBoxType { get; set; }
        public string DriverianType { get; set; }
        public string PetrolType { get; set; }
        public string BodyType { get; set; }
        #region Configuration
        public bool IsHaveCondicioner { get; set; }
        public bool IsHaveSeatsHeating { get; set; }
        public bool IsHaveCruiseControl { get; set; }
        public bool IsHaveGarageSaving { get; set; }
        public bool IsHaveDontHit { get; set; }
        public bool IsHaveFirstOwner { get; set; }
        public bool IsHaveMp3 { get; set; }
        public bool IsHaveSubbufer { get; set; }
        public bool IsHaveAirBags { get; set; }
        public bool IsHaveSleepingCheck { get; set; }
        #endregion
        public int DoorsCount { get; set; }
        public decimal CityСonsumption { get; set; }
        public decimal AutobanСonsumption { get; set; }
        public decimal MidleСonsumption { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
    }
}
