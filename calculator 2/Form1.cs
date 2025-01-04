using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1_txt.Text);
            double n2 = Convert.ToDouble(num2_txt.Text);
            result.Text=Convert.ToString(n1+ n2);
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1_txt.Text);
            double n2 = Convert.ToDouble(num2_txt.Text);
            result.Text=Convert.ToString(n1- n2);
        }

        private void times_btn_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1_txt.Text);
            double n2 = Convert.ToDouble(num2_txt.Text);
            result.Text=Convert.ToString(n1*n2);
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(num1_txt.Text);
            double n2 = Convert.ToDouble(num2_txt.Text);
            result.Text=Convert.ToString(n1/n2);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
           num1_txt.Clear();
           num2_txt.Clear();
           result.Clear();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
