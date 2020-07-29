using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int TotalPage { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
