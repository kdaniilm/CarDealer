using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public int PageCount { get; set; }
        public string Text { get; set; }
    }
}
