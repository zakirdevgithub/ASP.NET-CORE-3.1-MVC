using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Y_Partial_View_Multiple_Images_Pdf_Upload.Helpers;

namespace Y_Partial_View_Multiple_Images_Pdf_Upload.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        
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
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }

        
        public IFormFile BookPdf { get; set; }
        public string  BookPdfURL{ get; set; }

    }
}
