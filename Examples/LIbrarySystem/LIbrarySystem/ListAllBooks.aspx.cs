using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIbrarySystem
{
    public partial class ListAllBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var booksToDisplay = FileOperations.ReadBooksFromDataBase();

            this.booksRepeater.DataSource = booksToDisplay;
            this.booksRepeater.DataBind();
        }
    }
}