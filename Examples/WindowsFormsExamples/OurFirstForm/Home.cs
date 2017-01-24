using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurFirstForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "HAHHA";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "Парола";
            label2.ForeColor = Color.Yellow;
            label2.BackColor = Color.Tomato;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "Password:";
            label2.ForeColor = Color.Black;
            label2.BackColor = Color.Transparent;
        }
    }
}
