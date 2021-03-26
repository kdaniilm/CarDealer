using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class UserCarBuff
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public User CarOvner { get; set; }
        public IList<User> LikeUsers { get; set; }
    }
}
