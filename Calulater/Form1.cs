using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulater
{
    public partial class Form1 : Form
    {
        double Number_1;
        double Number_2;
        double Result;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void bntno1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void bntno2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void bntno3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void bntno4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void bntno5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void bntno6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void bntno7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void bntno8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void bntno9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void bntno0_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "0";
        }

        private void bntdot_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Number_1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            Number_1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void division_Click(object sender, EventArgs e)
        {
            Number_1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void times_Click(object sender, EventArgs e)
        {
            Number_1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void off_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            bntno0.Enabled = false;
            bntno1.Enabled = false;
            bntno2.Enabled = false;
            bntno3.Enabled = false;
            bntno4.Enabled = false;
            bntno5.Enabled = false;
            bntno6.Enabled = false;
            bntno7.Enabled = false;
            bntno8.Enabled = false;
            bntno9.Enabled = false;
            add.Enabled = false;
            times.Enabled = false;
            division.Enabled = false;
            subtract.Enabled = false;
            equal.Enabled = false;
            bntdot.Enabled = false;
            clear.Enabled = false;
            //.Enabled = false;
        }

        private void equal_Click(object sender, EventArgs e)
        {
           
            Number_2 = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (Number_1 + Number_2);
                textBox1.Text = Convert.ToString(Result);
                Number_1 = Result;
            }

            if (Operation == "-")
            {
                Result = (Number_1 - Number_2);
                textBox1.Text = Convert.ToString(Result);
                Number_1 = Result;
            }

            if (Operation == "*")
            {
                Result = (Number_1 * Number_2);
                textBox1.Text = Convert.ToString(Result);
                Number_1 = Result;
            }

            if (Operation == "/")
            {
                Result = (Number_1 / Number_2);
                textBox1.Text = Convert.ToString(Result);
                Number_1 = Result;
            }

        }
    }
}
