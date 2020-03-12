using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Core_mvc.Data;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        private readonly MvcMovieContext _context;
        public HelloWorldController(MvcMovieContext context)
        {
            _context = context;
        }
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Movies.ToListAsync());
        //}
        //public async Task<IActionResult> Details(int? id)
        
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var movie = await _context.Movies
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(movie);
        //}
        public IActionResult Welcome(string name, int numTimes = 1)
        {

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}