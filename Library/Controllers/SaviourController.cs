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
          
            Saviour saviour = new Saviour();
            saviour.SaveAuthorToAccess(new Author()
                {
                    AuthorName = _authorName
                }
            );
            return Content("Запись сохранена");
        }


        [HttpPost]
        public ActionResult SavePublisher(string _publisherName)
        {

            Saviour saviour = new Saviour();
            saviour.SavePublisherToAccess(new Publisher(_publisherName));
            return Content("Запись сохранена");
        }

        [HttpPost]
        public ActionResult SaveBook(object Book)
        {

            Saviour saviour = new Saviour();
            saviour.SaveBookToAccess(new Book());
            return Content("Запись сохранена");
        }
    }
}
