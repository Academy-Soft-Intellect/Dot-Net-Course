using System;
using System.Collections.Generic;

namespace OtherEventsAndControls
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> data = new List<string>() { "One", "Two", "Three", "Four" };

            this.dataListBox.DataSource = data;
            this.dataListBox.DataBind();
        }
    }
}