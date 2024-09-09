using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Exceptions
{
    public class ExceptionsErrors : Exception
    {
        public ExceptionsErrors(string message) : base(message) 
        {
        
        }
    }
}
