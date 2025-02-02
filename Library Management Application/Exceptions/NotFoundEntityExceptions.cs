using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.Exceptions
{
    public class NotFoundEntityExceptions : Exception
    {
        public NotFoundEntityExceptions()
        {
        }

        public NotFoundEntityExceptions(string? message) : base(message)
        {
        }
    }
}
