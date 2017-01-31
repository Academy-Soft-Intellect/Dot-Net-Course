using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibrarySystem.Models;
using System.IO;
using LibrarySystem.Helpers;

namespace LibrarySystem
{
    public partial class Search : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            var keyWord = this.searchTitleTextBox.Text;

            var listOfAllBooks = BooksHelper.GetAllBooks();

            resultsRepeater.DataSource = listOfAllBooks.Where(b => b.Title.ToLower().Contains(keyWord.ToLower())).ToList();
            resultsRepeater.DataBind();
        }
    }
}