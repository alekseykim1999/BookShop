using Library.Repository;
using Library.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class MainController : Controller
    {
        BookListViewModel obj = new BookListViewModel();


        public IActionResult BookShow()
        {

            PublisherRepository library = new PublisherRepository();
            obj.AllBooks = library.GetBooks();
            return View(obj);


        }
    }
}
