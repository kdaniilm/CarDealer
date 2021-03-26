using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class ComfortConfiguration
    {
        public int Id { get; set; }
        public string ConfigName { get; set; }
        public decimal? ConfigPrice { get; set; }
    }
}
