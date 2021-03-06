﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstLibrary.Models
{
    public class BookAuthor
    {
        public int BookAuthorID { get; set; }
        public int BookID { get; set; }

        [Display(Name = "Author")]
        public string Name { get; set; }
        
        public virtual Book Book { get; set; }
    }
}