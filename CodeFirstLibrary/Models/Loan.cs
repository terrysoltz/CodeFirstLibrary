﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstLibrary.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public int BookID { get; set; }
        public int BranchID { get; set; }
        public int BorrowerID { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOut { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DueDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Borrower Borrower { get; set; }

    }
}