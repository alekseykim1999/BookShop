using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Models
{
    public class Author
    {

        private int Id { get; set; }
        public string AuthorName { get; set; }

        public Author(string _name)
        {
            this.AuthorName = _name;
        }
    }
}
