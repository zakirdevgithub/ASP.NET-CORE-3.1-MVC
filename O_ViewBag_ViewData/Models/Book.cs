using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_ViewBag_ViewData.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Pages { get; set; }
    }
}
