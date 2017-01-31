using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace LibrarySystem.Helpers
{
    public static class BooksHelper
    {
        private static string filePath = ConfigurationManager.AppSettings["filePath"];

        public static List<Book> GetAllBooks()
        {
            var listOfBooks = new List<Book>();

            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                while (line != null && line != string.Empty)
                {
                    var bookProperties = line.Split('|');

                    listOfBooks.Add(new Book()
                    {
                        Title = bookProperties[0],
                        Author = bookProperties[1],
                        Genre = bookProperties[2],
                        Price = double.Parse(bookProperties[3])
                    });

                    line = reader.ReadLine();
                }

                return listOfBooks;
            }
        }
    }
}