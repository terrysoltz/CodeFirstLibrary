﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstLibrary.Models
{
    public class LoanView
    {
        public Copies Copies { get; set; }
        public Loan Loan { get; set; }
    }
}