using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Core_mvc.Data;

namespace WebApplication_Core_mvc.ViewComponents
{
    public class LastNotificationsViewComponent : ViewComponent
    {

        //private readonly INotificationQueries _notificationQueries;
        //private readonly IUserRepository _userRepository;
        //public LastNotificationsViewComponent(INotificationQueries notificationQueries, IUserRepository userRepository)
        //{
        //    _notificationQueries = notificationQueries;
        //    _userRepository = userRepository;
        //}
        private readonly MvcMovieContext _context;
        public LastNotificationsViewComponent(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Position.ToListAsync());
        }

    }
}
