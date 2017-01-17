using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAndEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("test@1", "sssssda");
            }
            catch (EmailException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }

        }
    }
}
