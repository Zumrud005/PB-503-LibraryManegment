using Library_Management_Application.DTOs.AuthorDtos;
using Library_Management_Application.DTOs.LoanItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface ILoanItemServices
    {
        void Add(LoanItemCreateDto loanItemCreateDto);
        void Update(int id, LoanItemUpdateDto loanItemUpdateDto);
        LoanItemGetDto GetById(int id);
        List<LoanItemGetDto> GetAll();
        void Remove(int id);
    }
}
