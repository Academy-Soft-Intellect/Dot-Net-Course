using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library2
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}