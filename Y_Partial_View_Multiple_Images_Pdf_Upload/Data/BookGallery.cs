using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Y_Partial_View_Multiple_Images_Pdf_Upload.Data
{
    public class BookGallery
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Book Book { get; set; }
    }
}
