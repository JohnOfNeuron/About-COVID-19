using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About_COVID_19_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Slidepanel.Height = button1.Height;
            Slidepanel.Top = button1.Top;
            userControlHome2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button1.Height;
            Slidepanel.Top = button1.Top;
            userControlHome2.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button2.Height;
            Slidepanel.Top = button2.Top;
            faQ13.BringToFront();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button3.Height;
            Slidepanel.Top =  button3.Top;
            faQ22.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button4.Height;
            Slidepanel.Top = button4.Top;
            faQ32.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button5.Height;
            Slidepanel.Top = button5.Top;
            summary2.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button6.Height;
            Slidepanel.Top = button6.Top;
            mythBusters2.BringToFront();
        }

     
        private void button13_Click(object sender, EventArgs e)
        {
            Slidepanel.Height = button13.Height;
            button13.ForeColor = Color.LightGreen;
            Slidepanel.Top = button13.Top;
            about2.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "www.facebook.com/yohannesaklilu";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "www.instagram.com/yohannesaklilu";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "t.me/neuronapps";
        }
    }
}
