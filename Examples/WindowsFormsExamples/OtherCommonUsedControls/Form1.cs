using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherCommonUsedControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<User> InitializeUsersList()
        {
            var usersList = new List<User>();

            usersList.Add(new User()
            {
                Mail = "first@user.com",
                Name = "FirstUser",
                Age = 25
            });

            usersList.Add(new User()
            {
                Mail = "second@user.com",
                Name = "SecondUser",
                Age = 35
            });

            usersList.Add(new User()
            {
                Mail = "third@user.com",
                Name = "ThirdUser",
                Age = 45
            });

            usersList.Add(new User()
            {
                Mail = "fourth@user.com",
                Name = "FourthUser",
                Age = 45
            });


            return usersList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = this.InitializeUsersList();

            this.dataGridView1.DataSource = users;
        }
    }
}
