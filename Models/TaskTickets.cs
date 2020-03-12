using System.ComponentModel.DataAnnotations;

namespace WebApplication_Core_mvc.Models
{
    public class TaskTickets
    {
        [Key]
        public int TicketId { get; set; }
        public int CategoryId { get; set; }
        public int SiteID { get; set; }

        public string Body { get; set; }
        public string ImageUrl { get; set; }


        [Display(Name = "Priority")]
        public int SeverityId { get; set; }
    }
}