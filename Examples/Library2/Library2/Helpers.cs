using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Library2
{
    public class Helpers
    {
        public static List<Book> PopulateBooks()
        {
            List<Book> books = new List<Book>();
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["DataBasePath"]))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string[] bookProperties = line.Split('|');
                    books.Add(new Book()
                    {
                        Title = bookProperties[0].Trim(),
                        Author = bookProperties[1].Trim(),
                        Genre = bookProperties[2].Trim(),
                        Price = double.Parse(bookProperties[3].Trim())
                    });
                    line = reader.ReadLine();
                }
            }
            return books;
        }
    }
}