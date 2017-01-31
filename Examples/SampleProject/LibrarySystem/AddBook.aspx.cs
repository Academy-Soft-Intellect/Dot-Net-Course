using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class AddBook : System.Web.UI.Page
    {
        private string filePath = ConfigurationManager.AppSettings["filePath"]; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBookButton_Click(object sender, EventArgs e)
        {
            var bookToAdd = new Book()
            {
                Title = this.titleTextBox.Text,
                Author = this.authorTextBox.Text,
                Genre = this.genreTextBox.Text,
                Price = double.Parse(this.priceTextBox.Text)
            };

            this.AddBookToFile(bookToAdd);
        }

        private void AddBookToFile(Book bookToAdd)
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(bookToAdd.CastToDataBaseRow());
            }
        }
    }
}