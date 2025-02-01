using Library_Management_Application.Data;
using Library_Management_Application.Models;
using Library_Management_Application.Repostories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repostories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _appDbContext;
        public int Commit()
        {
            return _appDbContext.SaveChanges();
        }

        public void Create(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            return _appDbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _appDbContext.Set<T>().FirstOrDefault(x => x.Id==id);
        }
    }
}
