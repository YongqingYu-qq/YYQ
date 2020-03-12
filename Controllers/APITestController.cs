using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_Core_mvc.Data;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APITestController : ControllerBase
    {
        private readonly MvcMovieContext _context;
        public APITestController(MvcMovieContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Consignment>> GetConsignment(Guid id)
        {
            var consignment = await _context.Consignment.Where(x => x.Id ==id)
                .Include(conline => conline.ConsignmentLine)
                .FirstOrDefaultAsync() ;
            return consignment;
        }
    }
}