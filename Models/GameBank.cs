using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_mvc.Models
{
    public class GameBank
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime RequestDateTime { get; set; }
        public string Status { get; set; }
    }
}
