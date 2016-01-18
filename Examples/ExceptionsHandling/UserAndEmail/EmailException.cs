using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndEmail
{
    public class EmailException : Exception
    {
        public EmailException(String message)
            : base(message)
        {
        }
    }
}
