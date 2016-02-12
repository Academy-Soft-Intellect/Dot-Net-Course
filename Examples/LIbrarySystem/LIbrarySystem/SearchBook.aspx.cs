using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIbrarySystem
{
    public partial class SearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            this.messageLabel.Text = "";

            var booksInLibrary = FileOperations.ReadBooksFromDataBase();

            var booksContainingKeyWord = new List<Book>();

            foreach (var book in booksInLibrary.Where(b =>
                                b.Author.ToLower().Contains(this.keyWordTxtBox.Text.ToLower()) ||
                                b.Title.ToLower().Contains(this.keyWordTxtBox.Text.ToLower())))
            {
                booksContainingKeyWord.Add(book);
            }

            if (booksContainingKeyWord.Count == 0)
            {
                this.messageLabel.Text = "No results found";
            }
            this.booksRepeater.DataSource = booksContainingKeyWord;
            this.booksRepeater.DataBind();
        }
    }
}