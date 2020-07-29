using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_Form_Validation.Data
{
    public class CopyBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int TotalPage { get; set; }
    }
}
