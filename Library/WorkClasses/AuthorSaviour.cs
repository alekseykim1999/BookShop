using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.WorkClasses
{
    //класс для сохранения в БД
    public class AuthorSaviour
    {
        public void SaveAuthorToAccess(Author person)
        {
            string ss = person.AuthorName;
        }
        
    }
}
