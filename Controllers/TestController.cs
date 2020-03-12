using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>() {
            new Product { id=1,name="xa",amount=100},
            new Product { id=2,name="cv",amount=300},
            new Product { id=3,name="few",amount=500},
            new Product { id=4,name="rt",amount=590},
            };
            ViewBag.Listdata = new List<int>() { 1, 2, 3, 4, 5 };
            return View(products);
        }
    }
}