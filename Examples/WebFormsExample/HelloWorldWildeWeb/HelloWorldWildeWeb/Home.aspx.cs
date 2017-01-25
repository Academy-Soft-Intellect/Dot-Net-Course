using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWildeWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            submitButton.Text = "Submit";
            goToGooleLink.ToolTip = "Go to google";
            userNameTxtBox.Text = "Enter username";
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "XAXA";

            userNameTxtBox.Text = "Submit clicked";

            userNameTxtBox.Text = this.selectRadioBtn.SelectedValue;

            selectRadioBtn.Items[0].Enabled = true;

            testLabel.Text = "Hello " + userNameTxtBox.Text;
        }
    }
}