using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_IDENTITY_EXAMPLE_UI_.Models
{
    public class CarViewModel
    {
        public bool IsNew { get; set; }
        public decimal CarPrice { get; set; }
        public int RunRange { get; set; }
        public CarModel Model { get; set; }
        public IList<string> ImagePathes { get; set; }
        public IList<ComfortConfiguration> ComfortList { get; set; }
        public IList<StateConfiguration> StateList { get; set; }
        public IList<MultiMediaConfiguration> MultiMediaList { get; set; }
        public IList<SaveConfiguration> SaveList { get; set; }
        public BaseConfiguration Base { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
