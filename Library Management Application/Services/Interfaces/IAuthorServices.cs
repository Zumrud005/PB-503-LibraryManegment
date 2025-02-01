using Library_Management_Application.DTOs.AuthorDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Interfaces
{
    public interface IAuthorServices
    {
        void Add (AuthorCreateDto authorCreateDto);
        void Update (int id,AuthorUpdateDto authorUpdateDto);
        AuthorGetDto GetById (int id);
        List<AuthorGetDto> GetAll();
        void Remove(int id);
 
    }
}
