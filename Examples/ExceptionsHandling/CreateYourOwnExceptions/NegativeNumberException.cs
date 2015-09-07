using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CreateYourOwnExceptions
{
    public class NegativeNumberException : Exception
    {
        /// <summary>
        /// Just create the exception
        /// </summary>
        public NegativeNumberException()
            : base()
        {
        }

        /// <summary>
        /// Create the exception with description
        /// </summary>
        /// <param name="message">Exception description</param>
        public NegativeNumberException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Create the exception with description and inner cause
        /// </summary>
        /// <param name="message">Exception description</param>
        /// <param name="innerException">Exception inner cause</param>
        public NegativeNumberException(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
