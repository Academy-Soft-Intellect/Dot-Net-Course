using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryBrowse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter which directory you want to browse");
            char dir = char.Parse(Console.ReadLine());
            string root = dir + @":\";
            browseDirectory(root);
        }

        private static void browseDirectory(string root)
        {
            string[] dir = { };
            try
            {
                dir = Directory.GetDirectories(root);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You are not authorized to access this directory");
            }
            if (dir.Length > 0)
            {
                for (int i = 0; i < dir.Length; i++)
                {
                    browseDirectory(dir[i]);
                }
            }
            else
            {
                try
                {
                    dir = Directory.GetFiles(root);
                    string[] filePaths = Directory.GetFiles(root);
                    for (int i = 0; i < filePaths.Length; i++)
                    {
                        Console.WriteLine(filePaths[i]);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You are not authorized to access this file");
                }
            }
        }
    }
}
