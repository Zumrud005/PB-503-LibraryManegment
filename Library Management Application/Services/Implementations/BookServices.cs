using Library_Management_Application.DTOs.BookDtos;
using Library_Management_Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Implementations
{
    public class BookServices : IBookServices
    {
        public void Add(BookCreateDto bookCreateDto)
        {
            throw new NotImplementedException();
        }

        public List<BookGetDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookGetDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, BookUpdateDto bookUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
