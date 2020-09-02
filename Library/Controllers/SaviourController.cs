using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data.Models;
using Library.WorkClasses;

namespace Library.Controllers
{
    public class SaviourController : Controller
    {
        [HttpPost]
        public ActionResult SaveAuthor(string _authorName)
        {
          
            AuthorSaviour saviour = new AuthorSaviour();
            saviour.SaveAuthorToAccess(new Author(_authorName));
            return Content("Запись сохранена");
        }
    }
}
