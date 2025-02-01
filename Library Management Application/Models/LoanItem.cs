using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Models
{
    public class LoanItem :BaseEntity
    {
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
