using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication_Core_mvc.Controllers
{
    public class EnumSelectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}