using Library_Management_Application.Data;
using Library_Management_Application.Models;
using Library_Management_Application.Repostories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repostories.Implementations
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly AppDbContext _appDbContext;   
        public List<Book> IGetAll()
        {
            return _appDbContext.Books.Include(x=>x.Authors).ToList();
        }

        public Book IGetById(int id)
        {
            return _appDbContext.Books.Include(x => x.Authors).FirstOrDefault(x=>x.Id==id);
        }
    }
}
