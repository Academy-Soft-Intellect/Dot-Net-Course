using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem.Models
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public double Price { get; set; }

        public string CastToDataBaseRow()
        {
            return string.Format("{0}|{1}|{2}|{3}", this.Title, this.Author, this.Genre, this.Price);
        }
    }
}