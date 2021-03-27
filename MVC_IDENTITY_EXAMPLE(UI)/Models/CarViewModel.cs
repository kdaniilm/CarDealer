using Domain.Model;
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
        [Required(ErrorMessage = "Price must be a number")]
        public decimal CarPrice { get; set; }
        public int RunRange { get; set; }
        [Required(ErrorMessage = "Select car model")]
        public CarModel Model { get; set; }
        public IList<ImagePath> ImagePathes { get; set; } 
        public IList<ComfortConfiguration> ComfortList { get; set; }
        public IList<StateConfiguration> StateList { get; set; }
        public IList<MultiMediaConfiguration> MultiMediaList { get; set; }
        public IList<SaveConfiguration> SaveList { get; set; }
        [Required(ErrorMessage = "Commite the base specification")]
        public BaseConfiguration Base { get; set; }
        public IList<Comment> Comments { get; set; }
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
