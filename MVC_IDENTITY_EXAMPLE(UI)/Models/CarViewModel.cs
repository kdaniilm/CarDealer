﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Models
{
    public class CarViewModel
    {
        public bool IsNew { get; set; }
        [Required]
        public decimal CarPrice { get; set; }
        [Required]
        public int RunRange { get; set; }
        [Required]
        public string CarBrend { get; set; }
        [Required]
        public string ModelName { get; set; }
        public IList<string> ImagePathes { get; set; }
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
        [Required]
        public string GearBoxType { get; set; }
        public int GearCount { get; set; }
        [Required]
        public string DriverianType { get; set; }
        public int DoorsCount { get; set; }
        [Required]
        public string BodyType { get; set; }

        #region Engine
        public decimal? Volume { get; set; }
        public int CylinderCount { get; set; }
        [Required]
        public string PetrolType { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public int MaxRpm { get; set; }
        public int MaxPowerRpm { get; set; }
        public int MaxTorqueRpm { get; set; }
        public decimal CityСonsumption { get; set; }
        public decimal AutobanСonsumption { get; set; }
        public decimal MidleСonsumption { get; set; }
        [Required]
        public string BoostType { get; set; }
        #endregion

        #region Bad style
        //public IList<Comment> Comments { get; set; }
        //public int Id { get; set; }
        //public bool IsNew { get; set; }
        //[Required(ErrorMessage = "Price must be a number")]
        //public decimal CarPrice { get; set; }
        //public int RunRange { get; set; }
        //[Required(ErrorMessage = "Select car model")]
        //public string ModelName { get; set; }
        //[Required(ErrorMessage = "Select car brend")]
        //public string BrendName { get; set; }
        //public string CountryName { get; set; }
        ////[Required(ErrorMessage = "Select car model")]
        //public IList<string> ImagePathes { get; set; }
        //public IList<string> ComfortConfigName { get; set; }
        //public IList<decimal?> ComfortConfigPrice { get; set; }
        //public IList<string> StateConfigName { get; set; }
        //public IList<decimal?> StateConfigPrice { get; set; }
        //public IList<string> MultiMediaConfigName { get; set; }
        //public IList<decimal?> MuliMediaConfigPrice { get; set; }
        //public IList<string> SaveConfigName { get; set; }
        //public IList<decimal?> SaveConfigPrice { get; set; }
        //[Required(ErrorMessage = "select GearBox type")]
        //public string GearBoxType { get; set; }
        //[Required(ErrorMessage = "insert Gear count")]
        //public int GearCount { get; set; }
        //[Required(ErrorMessage = "select Driverian type")]
        //public string DriverianType { get; set; }
        //[Required(ErrorMessage = "insert Doors count")]
        //public int DoorsCount { get; set; }
        //public string BodyType { get; set; }
        //public decimal? Volume { get; set; }
        //[Required(ErrorMessage = "insert Cylinder count")]
        //public int CylinderCount { get; set; }
        //[Required(ErrorMessage = "Choose petrol type")]
        //public string PetrolType { get; set; }
        //public int MaxPower { get; set; }
        //public int MaxTorque { get; set; }
        //public int MaxRpm { get; set; }
        //public int MaxPowerRpm { get; set; }
        //public int MaxTorqueRpm { get; set; }
        //public decimal CityСonsumption { get; set; }
        //public decimal AutobanСonsumption { get; set; }
        //public decimal MidleСonsumption { get; set; }
        //[Required(ErrorMessage = "select Boost type")]
        //public string Boost { get; set; }
        //public IList<Comment> Comments { get; set; }
        #endregion
    }
}
/*
 *bool IsNew
 *double CarPrice
 *int RunRange
 *select Brand
 *select Model
 *string ImagePathes
 *checkbox ComfortList
 *checkbox StateList
 *checkbox MultiMediaList
 *checkbox SaveList
 *select Base
 */
