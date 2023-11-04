using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception.Exceptions
{
    internal class OperationExceptions: SystemException
        {
        public OperationExceptions(): this("Number must not be negative")
        {
            
        }

        public OperationExceptions(string msj):base (msj)
        {
            
        }
    }
}
