using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.DTOs.LoanDtos
{
    public class LoanGetDto
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public string BorrowerNames { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime MustReturnTime { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
