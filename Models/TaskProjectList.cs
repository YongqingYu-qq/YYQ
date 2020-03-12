using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_mvc.Models
{
    public class TaskProjectList 
    {
        [Key]
        public int TaskProjectId { get; set; }

        public int TicketId { get; set; }
        public TaskTickets TaskTickets { get; set; }

        [Display(Name = "Description of Item")]
        public string ItemDescription { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }

        [Display(Name = "Price(N) / Quantity")]
        public double Price { get; set; }
        public bool Pass { get; set; }
        public bool Fail { get; set; }
    }
}
