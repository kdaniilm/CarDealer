using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public User UserHoCommented { get; set; }
        public int Grade { get; set; }
        public string CommentText { get; set; }
    }
}
