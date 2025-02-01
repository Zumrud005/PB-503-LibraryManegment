using Library_Management_Application.DTOs.LoanDtos;
using Library_Management_Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Implementations
{
    public class LoanServices : ILoanServices
    {
        public void Add(LoanCreateDto loanCreateDto)
        {
            throw new NotImplementedException();
        }

        public List<LoanGetDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public LoanGetDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, LoanUpdateDto loanUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
