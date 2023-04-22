using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mathlab;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double c = (double)numericUpDown3.Value;
            double d = (double)numericUpDown4.Value;
            double f = 0.5;
            if (checkBox1.Checked == true)
            {
                double v1 = Matan.VerSumm(a, b);
                double v2 = Matan.VerSumm(d, c);
                double g  = Matan.VerUn(a, v1);
                double h  = Matan.VerUn(c, v2);
                double i  = Matan.VerVer(g, f);
                double j  = Matan.VerVer(h, f);
                double result = Matan.VerOt(j, i);
                String temp = "";
                temp += Convert.ToString(result);
                MessageBox.Show(temp,"Answer");
            }
            else if (checkBox2.Checked == true)
            {
                double v1 = Matan.VerSumm(a, b);
                double v2 = Matan.VerSumm(d, c);
                double g = Matan.VerUn(b, v1);
                double h = Matan.VerUn(d, v2);
                double i = Matan.VerVer(g, f);
                double j = Matan.VerVer(g, f);
                double result = Matan.VerOt(j, i);
                String temp = "";
                temp += Convert.ToString(result);
                MessageBox.Show(temp ,"Answer");
            }
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
