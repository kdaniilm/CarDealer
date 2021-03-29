using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dto
{
    public class CarDto
    {
        public bool IsNew { get; set; }
        public decimal CarPrice { get; set; }
        public int RunRange { get; set; }
        public int BrendId { get; set; }
        public int ModelId { get; set; }
        public IList<string> ImagePathes { get; set; }
        public IList<int> ComfortList { get; set; }
        public IList<int> StateList { get; set; }
        public IList<int> MultiMediaList { get; set; }
        public IList<int> SaveList { get; set; }
        public string GearBoxType { get; set; }
        public int GearCount { get; set; }
        public string DriverianType { get; set; }
        public int DoorsCount { get; set; }
        public string BodyType { get; set; }
        public decimal? Volume { get; set; }
        public int CylinderCount { get; set; }
        public int PetrolTypeId { get; set; }
        public int MaxPower { get; set; }
        public int MaxTorque { get; set; }
        public int MaxRpm { get; set; }
        public int MaxPowerRpm { get; set; }
        public int MaxTorqueRpm { get; set; }
        public decimal CityСonsumption { get; set; }
        public decimal AutobanСonsumption { get; set; }
        public decimal MidleСonsumption { get; set; }
        public int BoostTypeId { get; set; }
        //public IList<Comment> Comments { get; set; }
        //public int Id { get; set; }
        //public bool IsNew { get; set; }
        //public decimal CarPrice { get; set; }
        //public int RunRange { get; set; }
        //public string ModelName { get; set; }
        //public string BrendName { get; set; }
        //public string CountryName { get; set; }
        //public IList<string> ImagePathes { get; set; }
        //public IList<string> ComfortConfigName { get; set; }
        //public IList<decimal?> ComfortConfigPrice { get; set; }
        //public IList<string> StateConfigName { get; set; }
        //public IList<decimal?> StateConfigPrice { get; set; }
        //public IList<string> MultiMediaConfigName { get; set; }
        //public IList<decimal?> MuliMediaConfigPrice { get; set; }
        //public IList<string> SaveConfigName { get; set; }
        //public IList<decimal?> SaveConfigPrice { get; set; }
        //public string GearBoxType { get; set; }
        //public int GearCount { get; set; }
        //public string DriverianType { get; set; }
        //public int DoorsCount { get; set; }
        //public string BodyType { get; set; }
        //public decimal? Volume { get; set; }
        //public int CylinderCount { get; set; }
        //public string PetrolType { get; set; }
        //public int MaxPower { get; set; }
        //public int MaxTorque { get; set; }
        //public int MaxRpm { get; set; }
        //public int MaxPowerRpm { get; set; }
        //public int MaxTorqueRpm { get; set; }
        //public decimal CityСonsumption { get; set; }
        //public decimal AutobanСonsumption { get; set; }
        //public decimal MidleСonsumption { get; set; }
        //public string Boost { get; set; }
        //public IList<Comment> Comments { get; set; }
    }
}
