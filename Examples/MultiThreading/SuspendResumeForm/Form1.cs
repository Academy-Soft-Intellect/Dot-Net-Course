using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuspendResumeForm
{
    public partial class Form1 : Form
    {
        private static Thread mThread;

        private const string MESSAGE = "This application demonstrates";

        public Form1()
        {
            InitializeComponent();
            mThread = new Thread(new ThreadStart(PrintMessages));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mThread.Start();

            }
            catch (Exception)
            {
                textBox1.Text += "Тъпак вече бачка";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mThread.Suspend();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mThread.Resume();
        }

        private void PrintMessages()
        {
            while (true)
            {
                foreach (char letter in MESSAGE.ToCharArray())
                {
                    textBox1.Text += letter;
                    Thread.Sleep(50);
                }
            }
        }

    }
}
