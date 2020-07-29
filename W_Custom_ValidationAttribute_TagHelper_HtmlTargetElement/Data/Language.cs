using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}
