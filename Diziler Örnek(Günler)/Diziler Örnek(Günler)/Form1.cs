using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "pazartesi";
            gunler[1] = "salı";
            gunler[2] = "çarşamba";
            gunler[3] = "perşembe";
            gunler[4] = "cuma";
            gunler[5] = "cumartesi";
            gunler[6] = "pazar";

            label1.Text = gunler[0];
            label2.Text = gunler[1];
            label3.Text = gunler[2];
            label4.Text = gunler[3];
            label5.Text = gunler[4];
            label6.Text = gunler[5];
            label7.Text = gunler[6];
              

        }
    }
}
