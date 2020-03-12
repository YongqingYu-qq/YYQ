using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_mvc.Models
{
    public class GameConfirmResponse
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime requestDateTime { get; set; }
        public string status { get; set; }
    }
}
