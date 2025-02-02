using Library_Management_Application.Data;
using Library_Management_Application.DTOs.BookDtos;
using Library_Management_Application.Exceptions;
using Library_Management_Application.Models;
using Library_Management_Application.Repostories.Implementations;
using Library_Management_Application.Repostories.Interfaces;
using Library_Management_Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Library_Management_Application.Services.Implementations
{
    public class BookServices : IBookServices
    {
        private readonly AppDbContext _appDbContext;
        public BookServices()
        {
            _appDbContext = new AppDbContext();
        }
        public void Add(BookCreateDto bookCreateDto)
        {
            if (string.IsNullOrWhiteSpace(bookCreateDto.Title)) throw new InvalidException("Book name has not null or empty");
            IBookRepository bookRopository = new BookRepository();
            var book = new Book();
            if (bookCreateDto.AuthorIds is null || !bookCreateDto.AuthorIds.Any()) throw new ArgumentException("At least one author must be selected");
            var authors = _appDbContext.Authors.Where(x => bookCreateDto.AuthorIds.Contains(x.Id)).ToList();
            if (book.Authors.Count != bookCreateDto.AuthorIds.Count) throw new Exception("Some authors not found");

            book.Title = bookCreateDto.Title;
            book.Desc = bookCreateDto.Desc;
            book.PublishedYear = bookCreateDto.PublishedYear;
            book.CreatedDate = DateTime.UtcNow.AddHours(4);
            book.UpdatedDate = DateTime.UtcNow.AddHours(4);
            book.IsDeleted = false;
            book.Authors = authors;
            bookRopository.Create(book);
            int result = bookRopository.Commit();
            Console.WriteLine($"{result} row affected");
        }

        public List<BookGetDto> GetAll()
        {
            return _appDbContext.Books
                                .Include(x => x.Authors)
                                .Select(x => new BookGetDto
                                {
                                    Id = x.Id,
                                    Title = x.Title,
                                    PublishedYear = x.PublishedYear,
                                    Desc = x.Desc,
                                    AuthorNames = x.Authors.Select(x => x.Name).ToList()
                                }).ToList();
        }

        public BookGetDto GetById(int id)
        {
            if (id < 1) throw new InvalidException("Id can not be less than 1");
            if (string.IsNullOrWhiteSpace(id.ToString())) throw new InvalidException("Id can not be null or empty");
            IBookRepository bookRepository = new BookRepository();
            var book = _appDbContext.Books.Include(x => x.Authors).FirstOrDefault(x => x.Id == id);

            if (book is null) throw new NotFoundEntityExceptions("Book not found");
            var bookGetDto = new BookGetDto();
            bookGetDto.Id = book.Id;
            bookGetDto.Title = book.Title;
            bookGetDto.Desc = book.Desc;
            bookGetDto.PublishedYear = book.PublishedYear;
            bookGetDto.AuthorNames = book.Authors.Select(x => x.Name).ToList();
            Console.WriteLine("Find book:");
            return bookGetDto;
        }

        public void Remove(int id)
        {
            if (id < 1) throw new InvalidException("Id can not be less than 1");
            if (id.ToString().IsNullOrEmpty()) throw new InvalidException("Id can not be null or empty");
            IBookRepository bookRepository = new BookRepository();
            var book = bookRepository.GetById(id);
            if (book is null) throw new NotFoundEntityExceptions("Book not found");
            book.IsDeleted = true;
            int result = bookRepository.Commit();
            Console.WriteLine($"{result} row affected");


        }

        public void Update(int id, BookUpdateDto bookUpdateDto)
        {
            if (id < 1) throw new InvalidException("Id can not be less than 1");
            if (id.ToString().IsNullOrEmpty()) throw new InvalidException("Id can not be null or empty");
            if (bookUpdateDto is null) throw new NotFoundEntityExceptions("");
            if (string.IsNullOrWhiteSpace(bookUpdateDto.Title)) throw new InvalidException("Book name has not null or empty");
            IBookRepository bookRepository = new BookRepository();
            var book = _appDbContext.Books.Include(x => x.Authors).FirstOrDefault(x => x.Id == id);
            if (book is null) throw new NotFoundEntityExceptions("Book not found");
            var authors = _appDbContext.Authors.Where(x => bookUpdateDto.AuthorIds.Contains(x.Id)).ToList();
            if (authors.Count != bookUpdateDto.AuthorIds.Count) throw new Exception("Some authors not found");
            book.Title = bookUpdateDto.Title;
            book.Desc = bookUpdateDto.Desc;
            book.PublishedYear = bookUpdateDto.PublishedYear;
            book.Authors = authors;
            book.UpdatedDate = DateTime.UtcNow.AddHours(4);
            int result = bookRepository.Commit();
            Console.WriteLine($"{result} row affected");



        }



    }
}
