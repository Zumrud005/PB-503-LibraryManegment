using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_Application.Models
{
    public class Book :BaseEntity
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public int PublishedYear { get; set; }
        public List<Author> Authors { get; set; }



    }
}
