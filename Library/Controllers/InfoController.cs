using Library.Data.Models;
using Library.Repository;
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
            
            return View();
        }

    }
}
