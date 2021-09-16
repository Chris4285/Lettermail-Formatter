using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2_IntroductionToCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFirstName, strLastName, strStreet, strCity, strPC, strProvince;
            strFirstName = txtFirstName.Text;
            strLastName = txtLastName.Text;
            strStreet = txtStreet.Text;
            strCity = txtCity.Text;
            strPC = txtPC.Text;
            strProvince = txtProvince.Text;
            lblOutput.Text = strFirstName + " " + strLastName + "\r\n " + strStreet + "\r\n " + strCity + ", " + strProvince + "\r\n " + strPC;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
