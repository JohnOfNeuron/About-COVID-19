using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace About_COVID_19_2._0
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            linkLabel2.Text = "johnny1623.jc@gmail.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "+251922106876";
        }
    }
}
