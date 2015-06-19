using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library2
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchPage.aspx");
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            double p;
            if (double.TryParse(priceTxtBox.Text, out p))
            {
                using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["DataBasePath"], true))
                {
                    writer.WriteLine(string.Format("{0} | {1} | {2} | {3}", titleTxtBox.Text, authorTxtBox.Text, genreTxtBox.Text, priceTxtBox.Text));
                }
                priceErrorLabel.Visible = false;
                Response.Redirect("Home.aspx");
            }
            else
            {
                priceErrorLabel.Text = "Enter a valid price";
                priceErrorLabel.Visible = true;
            }
        }

    }
}