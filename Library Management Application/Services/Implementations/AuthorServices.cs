using Library_Management_Application.Data;
using Library_Management_Application.DTOs.AuthorDtos;
using Library_Management_Application.DTOs.BookDtos;
using Library_Management_Application.Exceptions;
using Library_Management_Application.Models;
using Library_Management_Application.Repostories.Implementations;
using Library_Management_Application.Repostories.Interfaces;
using Library_Management_Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Services.Implementations
{
    public class AuthorServices : IAuthorServices
    {
        
        public void Add(AuthorCreateDto authorCreateDto)
        {
            if (string.IsNullOrWhiteSpace(authorCreateDto.Name)) throw new InvalidException("Author name has not null or empty");
            IAuthorRepository authorRepository = new AuthorRepository();
            var author = new Author();
            author.Name = authorCreateDto.Name;
            authorRepository.Create(author);
            int result = authorRepository.Commit();
            Console.WriteLine($"{result} row affected");

        }


            
        public List<AuthorGetDto> GetAll()
        {
            IAuthorRepository authorRepository = new AuthorRepository();
            return authorRepository.IGetAll().Select(x => new AuthorGetDto
            {
                Id = x.Id,
                Name = x.Name,
                BookTitles = x.Books.Select(x => x.Title).ToList()
            }).ToList();
        }

        public AuthorGetDto GetById(int id)
        {
            if (id <= 0) throw new InvalidException("Id can not be less than 1");
            if (string.IsNullOrWhiteSpace(id.ToString())) throw new InvalidException("Id can not null or empty");
            IAuthorRepository authorRepository = new AuthorRepository();
            var author = authorRepository.GetById(id);
            if (author is null) throw new NotFoundEntityExceptions("Author not found");
            var authorGetDto = new AuthorGetDto();
            authorGetDto.Id = author.Id;
            authorGetDto.Name = author.Name;
            authorGetDto.BookTitles = author.Books.Select(x => x.Title).ToList();
            return authorGetDto;    
        }

        public void Remove(int id)
        {
            if (id <= 0) throw new InvalidException("Id can not be less than 1");
            if (string.IsNullOrWhiteSpace(id.ToString())) throw new InvalidException("Id can not null or empty");
            IAuthorRepository authorRepository = new AuthorRepository();
            var author = authorRepository.GetById(id);
            if (author is null) throw new NotFoundEntityExceptions("Author not found");
            authorRepository.Delete(author);
            int result = authorRepository.Commit();
            Console.WriteLine($"{result} row affected");
        }

        public void Update(int id, AuthorUpdateDto authorUpdateDto)
        {
            if (id <= 0) throw new InvalidException("Id can not be less than 1");
            if (string.IsNullOrWhiteSpace(id.ToString())) throw new InvalidException("Id can not null or empty");
            if (authorUpdateDto == null) throw new NotFoundEntityExceptions();
        }
    }
}
