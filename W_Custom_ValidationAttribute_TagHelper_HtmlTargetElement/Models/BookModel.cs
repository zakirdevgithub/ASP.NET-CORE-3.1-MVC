using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Helper;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Models
{
    public class BookModel
    {
        public int Id { get; set; }
       [MyCustomValidation("Book", ErrorMessage ="Please Include Book")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        [Required] 
        public int TotalPage { get; set; }
        public int LanguageId { get; set; }
        public string Language { get; set; }
        
    }
}
