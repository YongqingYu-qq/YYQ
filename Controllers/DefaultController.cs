using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using WebApplication_Core_mvc.Data;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Controllers
{
    public class DefaultController : Controller
    {
        private readonly MvcMovieContext _context;
        public DefaultController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.ViewModel1.ToList());
        }

        public IActionResult showprofile(int id)
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Create([FromBody]TaskCreate taskCreate)
        {
            var viewModel = new ClassModel();
            if (ModelState.IsValid)
            {
                var taskTickets = new TaskTickets
                {
                    //Created = true,
                    //StatusId = 0,
                    CategoryId = taskCreate.CategoryId,
                    SiteID = taskCreate.SiteID,
                    SeverityId = taskCreate.SeverityId

                };
                _context.Add(taskTickets);

                foreach (TaskProjectList item in taskCreate.TaskProjectList)
                {
                    item.TicketId = taskTickets.TicketId;

                    _context.TaskProjectList.Add(item);
                }

                int save = _context.SaveChanges();

                return View(save);
            }
            //ViewData["SiteID"] = new SelectList(_context.AdmSite, "SiteID", "Sitename");
            //ViewData["CategoryId"] = new SelectList(_context.TaskCategory, "CategoryId", "CategoryName");
            //ViewData["SeverityId"] = new SelectList(_context.TaskSeverity, "SeverityId", "SeverityName");
            viewModel.ProjectList = _context.TaskProjectList.ToList();
            return View(viewModel);
        }
    }

    public class ClassModel
    {
        public List<TaskProjectList> ProjectList { get; set; }
    }
}