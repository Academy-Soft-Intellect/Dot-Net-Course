using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace Library2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> books = Helpers.PopulateBooks();

            booksGridView.DataSource = books;
            booksGridView.DataBind();
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchPage.aspx");
        }

        protected void addBookBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow row = (sender as LinkButton).Parent.Parent as GridViewRow;

            string titleOfBookToDelete = row.Cells[0].Text;

            List<Book> books = Helpers.PopulateBooks();

            Book bookToDelete = new Book();

            foreach (Book book in books)
            {
                if (book.Title == titleOfBookToDelete)
                {
                    bookToDelete = book;
                }
            }


            books.Remove(bookToDelete);

            PopulateBooks(books);

            Response.Redirect("Home.aspx");
        }

        private void PopulateBooks(List<Book> books)
        {
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["DataBasePath"]))
            {
                foreach (Book book in books)
                {
                    writer.WriteLine(string.Format("{0} | {1} | {2} | {3}", book.Title, book.Author, book.Genre, book.Price));
                }
            }
        }
    }
}