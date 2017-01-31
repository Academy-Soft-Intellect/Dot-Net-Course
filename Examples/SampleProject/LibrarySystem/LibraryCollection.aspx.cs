using LibrarySystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class LibraryCollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listOfAllBooks = BooksHelper.GetAllBooks();

            resultsRepeater.DataSource = listOfAllBooks;
            resultsRepeater.DataBind();
        }
    }
}