using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Models
{
    public class FilterViewModel
    {
        public bool? IsNew { get; set; } //select``
        public decimal MinPrice { get; set; } //number``
        public decimal MaxPrice { get; set; } //number``
        public int MinRange { get; set; }//number``
        public int MaxRange { get; set; }//number``
        public string CreateCountryName { get; set; } //select``
        public string BrendName { get; set; } //select``
        public string ModelName { get; set; }//select``
        public string GearBoxType { get; set; }//select``
        public string DriverianType { get; set; }//select``
        public string PetrolType { get; set; }//select``
        public string BodyType { get; set; }//select``
        #region Configuration
        public bool IsHaveCondicioner { get; set; } //chekbox
        public bool IsHaveSeatsHeating { get; set; }//chekbox
        public bool IsHaveCruiseControl { get; set; }//chekbox
        public bool IsHaveGarageSaving { get; set; }//chekbox
        public bool IsHaveDontHit { get; set; }//chekbox
        public bool IsHaveFirstOwner { get; set; }//chekbox
        public bool IsHaveMp3 { get; set; }//chekbox``
        public bool IsHaveSubbufer { get; set; }//chekbox``
        public bool IsHaveAirBags { get; set; }//chekbox``
        public bool IsHaveSleepingCheck { get; set; }//chekbox``
        #endregion
        public int DoorsCount { get; set; } //number``
        public decimal CityСonsumption { get; set; } //number
        public decimal AutobanСonsumption { get; set; } //number
        public decimal MidleСonsumption { get; set; } //number
        public int MaxPower { get; set; } //number
        public int MaxTorque { get; set; } //number
        public int StartYear { get; set; } //number
        public int EndYear { get; set; } //number
    }
}
