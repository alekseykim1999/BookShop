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
        private Saviour saviour = new Saviour();
        [HttpPost]
        public ActionResult SaveAuthor(string _authorName)
        {
          
            
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

           
            saviour.SavePublisherToAccess(new Publisher(_publisherName));
            return Content("Запись сохранена");
        }

        [HttpPost]
        public ActionResult SaveBook(IFormCollection form)
        {
            Book book = new Book();

            book.BookName= form["_bookName"].ToString();
            book.Description = form["_description"].ToString();
            book.ReleaseDate = form["_release"].ToString();
            book.Price = Convert.ToInt32(form["_price"]);
            book.Publisher = form["_publisher"].ToString();
           
            
            saviour.SaveBookToAccess(book);
            return Content("Запись сохранена");
        }
    }
}
