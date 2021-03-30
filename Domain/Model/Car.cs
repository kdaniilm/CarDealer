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
        //public CarModel Model { get; set; }
        public string ModelName { get; set; }
        public string CarBrend { get; set; }
        public string CreateCountryName { get; set; }
        public IList<ImagePath> ImagePathes { get; set; }
        public IList<ComfortConfiguration> ComfortList { get; set; }
        public IList<StateConfiguration> StateList { get; set; }
        public IList<MultiMediaConfiguration> MultiMediaList { get; set; }
        public IList<SaveConfiguration> SaveList { get; set; }
        //public BaseConfiguration Base { get; set; }
        public string GearBoxType { get; set; }
        public int GearCount { get; set; }
        public string DriverianType { get; set; }
        public int DoorsCount { get; set; }
        public string BodyType { get; set; }
        public Engine Engine { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
