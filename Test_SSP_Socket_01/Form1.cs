//using MetroFramework.Forms;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_SSP_Socket_01
{
    //public partial class Form1 : MetroForm
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void start()
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button2_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string str = this.textBox1.Text;

            Console.WriteLine (str);
            //this.textBox2.Text = str;
            this.button8.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

