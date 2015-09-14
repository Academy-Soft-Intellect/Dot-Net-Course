using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurFirstWindowsForm
{
    public partial class OurForm : Form
    {
        public OurForm()
        {
            InitializeComponent();

        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            OurSecondForm secondForm = new OurSecondForm();
            secondForm.Show();
            secondForm.FormClosing += secondForm_FormClosing; 
        }

        private void secondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBox secondFormTextBox = ((sender as Form).Controls.Find("textBox1",true).First()) as TextBox;
            label1.Text = secondFormTextBox.Text;
        }
    }
}
