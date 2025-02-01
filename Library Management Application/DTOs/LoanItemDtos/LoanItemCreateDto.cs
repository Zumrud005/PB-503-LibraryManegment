using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.DTOs.LoanItemDtos
{
    public class LoanItemCreateDto
    {
        public int BookId { get; set; } 
        public int LoanId { get; set; }
    }
}
