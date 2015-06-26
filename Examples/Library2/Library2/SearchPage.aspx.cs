using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library2
{
    public partial class SearchPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void addBookBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            List<Book> books = Helpers.PopulateBooks();
            List<Book> results = books.Where(b => b.Title.ToLower().Contains(titleTxtBox.Text.ToLower())).ToList();
           
            
            //List<Book> results = new List<Book>();
            //foreach (Book book in books)
            //{
            //    if (book.Title.ToLower().Contains(titleTxtBox.Text.ToLower()))
            //    {
            //        results.Add(book);
            //    }
            //}

            resultsRepeater.DataSource = results;
            resultsRepeater.DataBind();
        }
    }
}