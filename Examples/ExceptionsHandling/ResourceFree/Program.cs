using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceFree
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter reader = new StreamWriter("");
            try
            {
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                reader.Close();
            }

        }
    }
}
