using Library_Management_Application.Data;
using Library_Management_Application.Models;
using Library_Management_Application.Repostories.Interfaces;
using Library_Management_Application.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repostories.Implementations
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        public AuthorRepository()
        {
            _context = new AppDbContext();
        }
        public List<Author> IGetAll()
        {
           return _context.Authors.Include(x=>x.Books).ToList();    
        }

        public Author IGetById(int id)
        {
            return _context.Authors.Include(x => x.Books).FirstOrDefault(x=>x.Id==id);
        }
    }
}
