using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageComment
    {
        [Key]
        public int CommentId { get; set; }

        [Display(Name = "خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        public int PageId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(200)]
        public string Eamil { get; set; }

        [Display(Name = "وبسایت")]
        [MaxLength(200)]
        public string Website { get; set; }

        [Display(Name = "نظر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(500)]
        public string Commnet { get; set; }
        [Display(Name = "تاریخ ثبت")]
        public DateTime CreateDate { get; set; }

        public virtual Page Page { get; set; }

        public PageComment() { }
    }
}
