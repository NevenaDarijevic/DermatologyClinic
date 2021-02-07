using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class SystemOperationsException:Exception
    {
        public SystemOperationsException() : base("Server ne moze da obradi zahtev!")
        {
        }

        public SystemOperationsException(string message) : base(message)
        {

        }
    }
}
