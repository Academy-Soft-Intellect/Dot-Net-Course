using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndEmail
{
    class PasswordException: Exception
    {
        public PasswordException(String message)
            : base(message)
        {
        }
    }
}
