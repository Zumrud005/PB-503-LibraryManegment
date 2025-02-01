using Library_Management_Application.DTOs.AuthorDtos;
using Library_Management_Application.DTOs.BorrowerDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface IBorrowerServices
    {
        void Add(BorrowrCreateDto borrowrCreateDto);
        void Update(int id, BorrowerUpdateDto borrowerUpdateDto);
        BorrowerGetDto GetById(int id);
        List<BorrowerGetDto> GetAll();
        void Remove(int id);
    }
}
