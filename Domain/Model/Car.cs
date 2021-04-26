using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Car
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public decimal CarPrice { get; set; }
        public int RunRange { get; set; }
        public int ProductionYear { get; set; }
        public string ModelName { get; set; }
        public string CarBrend { get; set; }
        public string CreateCountryName { get; set; }
        public IList<ImagePath> ImagePathes { get; set; }
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
        public string GearBoxType { get; set; }
        public int GearCount { get; set; }
        public string DriverianType { get; set; }
        public int DoorsCount { get; set; }
        public string BodyType { get; set; }
        public Engine Engine { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
