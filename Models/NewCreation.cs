using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication_Core_mvc.Models
{
    public class Creation
    {
        public string UsrId { get; set; }
        [Key]
        public int CreationId { get; set; }
        public string CreationLanguage { get; set; }

        [Required(ErrorMessageResourceName = "Required")]
        [Display(Name = "Sex")]
        public string CreationSex { get; set; }

        [Required(ErrorMessageResourceName = "Required")]
        [Display(Name = "CreationTitle")]
        [StringLength(2000)]
        [AllowHtml]
        public string CreationTitle { get; set; }

        public bool CreationVisible { get; set; }
        public bool CreationDelete { get; set; }

        [Display(Name = "InsertDate")]
        public DateTime CreationDate { get; set; }
        public string CreationIpAdress { get; set; }

        public string CreationPhotoBis { get; set; }
        public string CreationPhoto750 { get; set; }
        public string CreationPhotoReal { get; set; }

        public int CreationAddLike { get; set; }

        public string Creationtag { get; set; }

        public virtual ICollection<CreationLike> CreationLikes { get; set; }

    }
    public class CreationLike
    {
        public int CreationId { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Key]
        public int CreationLikeId { get; set; }
        public DateTime CreationLikeDate { get; set; }
        public string CreationLikeIpAdress { get; set; }

        public virtual Creation ParentCreation { get; set; }

    }

    public class ApplicationUser
    {
        public int id { get; set; }
    }
}
