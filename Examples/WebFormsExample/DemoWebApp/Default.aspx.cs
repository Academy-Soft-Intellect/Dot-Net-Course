using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.nameLabel.ForeColor = System.Drawing.Color.BlueViolet;
        }

        protected void testButton_Click(object sender, EventArgs e)
        {
            this.nameLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.nameTextBox.Visible = true;

            Response.Redirect("About.aspx");
        }

        protected void linkBtn_Click(object sender, EventArgs e)
        {
            this.nameLabel.Text = this.nameTextBox.Text;
            this.nameTextBox.Visible = false;
        }

        protected void ddlNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.linkBtn.Text = ddlNew.SelectedItem.Value;
        }
    }
}