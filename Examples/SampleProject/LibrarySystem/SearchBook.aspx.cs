﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class SearchBook : System.Web.UI.Page
    {
        private static List<Book> books = Helpers.GetBooks();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            List<Book> results = new List<Book>();
            foreach (Book item in books)
            {
                if (item.Title.ToLower().Contains(searchTxtBox.Text.ToLower()))
                {
                    results.Add(item);
                }
            }
            booksRepeater.DataSource = results;
            //booksRepeater.DataSource = books.Where(item => item.Title.ToLower().Contains(searchTxtBox.Text.ToLower()));
            booksRepeater.DataBind();
        }

    }
}