using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    internal class InvalidYearException : Exception
    {
        public InvalidYearException()
            : base("User typed invalid year") { }
    }
}
