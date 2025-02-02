using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Repostories.Interfaces
{
    public interface IBookRepository :IGenericRepository<Book>
    {
        Book IGetById(int id);
        List<Book> IGetAll();
    }
        

}
