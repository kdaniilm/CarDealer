using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    class AiModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LikeCarBrend { get; set; }
        public string LikeCarModel { get; set; }
        public string LikeCarModelYear { get; set; }
        public string LikeCarPrice { get; set; }
    }
}
