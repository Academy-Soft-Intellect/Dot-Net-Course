using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtherEventsAndControls
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void toggleActiveTxtBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toggleActiveTxtBox.SelectedValue == "Active")
            {
                this.plainTxtBox.Enabled = true;
            }
            else
            {
                this.plainTxtBox.Enabled = false;
            }
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            this.indicateLabel.Text = this.plainTxtBox.Text;
        }
    }
}