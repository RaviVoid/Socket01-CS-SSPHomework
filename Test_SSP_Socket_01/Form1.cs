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
using System.Net;
using System.Net.Sockets;
using ConsoleAppClient_01;  // 참조프로젝트 네임스페이스
using ConsoleAppServer_01;  // 참조프로젝트 네임스페이스

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



        // 버튼 클릭 이벤트 구성 시작.
        int PortNumber;

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                PortNumber = Convert.ToInt32(this.textBox1.Text);
                await ServerProgram.RunServer(PortNumber);  // 참조 프로젝트 Server 호출
                Console.WriteLine(PortNumber);
                //this.button1.Enabled = false; // 동작안됨.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Listen_Button");

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            ConsoleAppServer_01.ServerProgram.RunServer(PortNumber).Dispose();




            Console.WriteLine("Close_Button");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SendFile_Button");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("SendTC_Button");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = this.textBox2.Text;
            Console.WriteLine(str);
            Console.WriteLine("SendMsg_Button");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Send Msg Clear_Button");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("종료(X)_Button");
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Receive Msg Clear_Button");
        }

        // 버튼 클릭 이벤트 구성 종료.

    }
}

