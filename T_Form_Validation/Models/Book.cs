using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T_Form_Validation.Models
{
    public class Book
    {
        [DataType(DataType.DateTime)]
        [Display(Name ="Enter Date and Time")]
        public string MyField { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Password")]

        public string Password { get; set; }
        public int Id { get; set; }
        [Required (ErrorMessage ="*Book Title is required")]
        public string Title { get; set; }
        [Required (ErrorMessage ="*Author Name is required")]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int TotalPage { get; set; }
    }
}
