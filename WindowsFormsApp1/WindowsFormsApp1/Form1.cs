using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string input = "";
        private void button_c_Click(object sender, EventArgs e)
        {
            input = "";
            textBox_input_output.Text = input;
        }

        private void button_divison_Click(object sender, EventArgs e)
        {
            input = input + "/"; 
            textBox_input_output.Text = input;
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            input = input + "*";
            textBox_input_output.Text = input;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            int num = int.Parse(input);
            if (num > 0)
            {
                num = num / 10;
                input = num.ToString();
                textBox_input_output.Text = input;
            }
            else if(num == 0)
            {
                input = "";
                textBox_input_output.Text = input;
            }
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            input = input + "7";
            textBox_input_output.Text = input;
        }

        private void button_eight_Click(object sender, EventArgs e)
        {
            input = input + "8";
            textBox_input_output.Text = input;
        }

        private void button_nine_Click(object sender, EventArgs e)
        {
            input = input + "9";
            textBox_input_output.Text = input;
        }

        private void button_four_Click(object sender, EventArgs e)
        {
            input = input + "4";
            textBox_input_output.Text = input;
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            input = input + "5";
            textBox_input_output.Text = input;
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            input = input + "6";
            textBox_input_output.Text = input;
        }

        private void button_one_Click(object sender, EventArgs e)
        {
            input = input + "0";
            textBox_input_output.Text = input;
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            input = input + "2";
            textBox_input_output.Text = input;
        }

        private void button_three_Click(object sender, EventArgs e)
        {
            input = input + "3";
            textBox_input_output.Text = input;
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            input = input + "0";
            textBox_input_output.Text = input;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            input = input + "-";
            textBox_input_output.Text = input;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            input = input + "+";
            textBox_input_output.Text = input;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {

        }

        private void button_point_Click(object sender, EventArgs e)
        {
            input = input + ".";
            textBox_input_output.Text = input;
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            input = input + "%";
            textBox_input_output.Text = input;
        }
    }
}
