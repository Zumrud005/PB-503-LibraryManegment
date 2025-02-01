using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.DTOs.LoanDtos
{
    public class LoanUpdateDto
    {
        public DateTime LoanDate { get; set; }
        public DateTime MustReturnTime { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
