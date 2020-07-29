using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using X_Client_Side_Validation_Upload_Image.Helpers;

namespace X_Client_Side_Validation_Upload_Image.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [MyCustomValidation("book", ErrorMessage ="Title is Requird")]
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
        public IFormFile CoverPhoto { get; set; }

        public string CoverImageUrl { get; set; }
        
    }
}
