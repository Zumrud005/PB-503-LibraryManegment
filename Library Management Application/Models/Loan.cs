using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Models
{
    public class Loan :BaseEntity
    {
        public DateTime LoanDate { get; set; }
        public DateTime MustReturnTime { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
        public List<LoanItem> LoanItems { get; set; }
    }
}
