using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceOut
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = string.Empty;
            var modifiedMail = ReferenceDemo("test", out userName);
            Console.WriteLine(userName);
        }

        static string ReferenceDemo(string mail, out string userName)
        {
            userName = "dasdasd";

            return mail + userName;
        }
    }
}
