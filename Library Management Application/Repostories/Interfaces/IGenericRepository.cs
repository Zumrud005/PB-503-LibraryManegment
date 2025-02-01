using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repostories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity,new()
    {
        void Create(T entity);
        T GetById(int id);
        List<T> GetAll();   
        void Delete(T entity);
        int Commit();




    }
}
