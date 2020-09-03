using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Desription { get; set; }
        public int Price { get; set; }
    }
}
