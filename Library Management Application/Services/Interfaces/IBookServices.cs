using Library_Management_Application.DTOs.AuthorDtos;
using Library_Management_Application.DTOs.BookDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface IBookServices
    {
        void Add(BookCreateDto bookCreateDto);
        void Update(int id, BookUpdateDto bookUpdateDto);
        BookGetDto GetById(int id);
        List<BookGetDto> GetAll();
        void Remove(int id);
    }
}
