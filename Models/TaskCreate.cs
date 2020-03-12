using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_mvc.Models
{
    public class TaskCreate
    {

        public int SeverityId { get; set; }
        public int CategoryId { get; set; }
        public int SiteID { get; set; }

        public List<TaskProjectList> TaskProjectList { get; set; }
    }
    
}
