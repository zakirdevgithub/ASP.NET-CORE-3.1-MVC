﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_Client_Side_Validation_Upload_Image.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}