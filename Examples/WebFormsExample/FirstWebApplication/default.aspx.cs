using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void carModelDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fuelType.Checked && carModelDDL.SelectedIndex != 0)
            {
                submitBtn.Enabled = true;
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void fuelType_CheckedChanged(object sender, EventArgs e)
        {
            if (fuelType.Checked && carModelDDL.SelectedIndex != 0)
            {
                submitBtn.Enabled = true;
            }
        }
    }
}