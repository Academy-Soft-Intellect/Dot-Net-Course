using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LIbrarySystem
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            var bookToAdd = new Book(
                this.titleTxtBox.Text, 
                this.authorTxtBox.Text, 
                double.Parse(this.priceTxtBox.Text));

            if (FileOperations.AddBookToDataBase(bookToAdd))
            {
                this.messageLabel.Text = "Successfully added the book to the library";
                this.titleTxtBox.Text = string.Empty;
                this.authorTxtBox.Text = string.Empty;
                this.priceTxtBox.Text = string.Empty;
            }
            else
            {
                this.messageLabel.ForeColor = System.Drawing.Color.Red;
                this.messageLabel.Text = "An error occured while adding the book";
            }
        }
    }
}