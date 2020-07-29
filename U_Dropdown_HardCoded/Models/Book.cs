using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using U_Dropdown_HardCoded.Enums;

namespace U_Dropdown_HardCoded.Models
{
    public class Book
    {
 
        public int Id { get; set; }

        [Required(ErrorMessage = "Book Title Is Required")]
        [Display(Name = "*Book Title")]
        public String Title { get; set; }

        [Required (ErrorMessage ="Author Name Is Required")]
        [Display(Name ="*Author Name")]
        public string Author { get; set; }

        [Required(ErrorMessage ="Description Is Required")]
        [StringLength(500, MinimumLength =5)]
        public string Description { get; set; }

        [Required(ErrorMessage ="Category Is Required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Total Page Is Required")]
        [Display(Name ="Total Page")]
        public int? TotalPage { get; set; }

        [Required(ErrorMessage = "Language Is Required")]
        public string Language { get; set; }


        [Required(ErrorMessage = "MultipleLanguage Is Required")]
        public List<string> MultipleLanguage { get; set; }

        [Required(ErrorMessage = "Language Is Required")]
        public LanguageEnum LanguageEnums { get; set; }
    }
}
