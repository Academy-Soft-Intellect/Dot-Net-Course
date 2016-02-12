using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIbrarySystem
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Title, this.Author, this.Price);
        }
    }
}