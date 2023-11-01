using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exception_Practice.Exceptions
{
    internal class RegisterFailedExceptions:Exception
    {
        public RegisterFailedExceptions():this ("ertyui")
        {
            
        }
        public RegisterFailedExceptions(string msj) : base(msj) 
        {
            
        }
    }
}
