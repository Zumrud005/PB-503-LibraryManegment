using Library_Management_Application.DTOs.AuthorDtos;
using Library_Management_Application.DTOs.LoanDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface ILoanServices
    {
        void Add(LoanCreateDto loanCreateDto);
        void Update(int id, LoanUpdateDto loanUpdateDto);
        LoanGetDto GetById(int id);
        List<LoanGetDto> GetAll();
        void Remove(int id);

    }
}
