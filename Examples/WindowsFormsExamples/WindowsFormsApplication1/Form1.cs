using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.userNameLabel.Text = this.textBox1.Text;

            var newForm = new Form2();
            newForm.label1.Text = this.userNameLabel.Text;
            newForm.FormClosed += NewForm_FormClosed;

            newForm.ShowDialog();
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = sender as Form2;

            this.textBox1.Text = form.textBox1.Text;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox1.Text))
            {
                this.loginBtn.Enabled = true;
            }
            else
            {
                this.loginBtn.Enabled = false;
            }
        }
    }
}
