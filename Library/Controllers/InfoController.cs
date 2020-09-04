using Library.Data.Models;
using Library.Repository;
using Library.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class InfoController : Controller
    {

        public ViewResult AddAuthor() 
        {

            return View(); 
        }

        public ViewResult AddPublisher() 
        {
            
            return View();
        }

        public ViewResult AddBook()
        {
            PublishersRepository companies = new PublishersRepository();
            PublisherViewModel obj = new PublisherViewModel();
            obj.AllPublishers = companies.GetPublishers();
            return View(obj);
        }

    }
}
