using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a.GetType());

            Stream inputStream = Console.OpenStandardInput();
            byte[] bytes = new byte[1536];    // 1.5kb
            int outputLength = inputStream.Read(bytes, 0, 1536);

            var myStr = System.Text.Encoding.UTF8.GetString(bytes);
        }
    }
}
