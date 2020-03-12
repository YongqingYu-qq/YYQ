using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Core_mvc.Models
{
    public class Consignment
    {
        public Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? Deleted { get; set; }
        public string Status { get; set; }
        public string Services { get; set; }
        public string CustomerReference { get; set; }
        public string ConsignmentNote { get; set; }
        public int? TotalPieces { get; set; }
        public virtual ICollection<ConsignmentLine> ConsignmentLine { get; set; } 
    }
}
