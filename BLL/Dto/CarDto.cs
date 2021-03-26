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
        public int Id { get; set; }
        public bool IsNew { get; set; }
        public decimal CarPrice { get; set; }
        public int RunRange { get; set; }
        public CarModel Model { get; set; }
        public IList<ImagePath> ImagePathes { get; set; }
        public IList<ComfortConfiguration> ComfortList { get; set; }
        public IList<StateConfiguration> StateList { get; set; }
        public IList<MultiMediaConfiguration> MultiMediaList { get; set; }
        public IList<SaveConfiguration> SaveList { get; set; }
        public BaseConfiguration Base { get; set; }
    }
}
