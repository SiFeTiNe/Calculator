using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string plusText = "+";
        string minusText = "-";
        string mulText = "x";
        string divText = "÷";
        string sqrtText = "√";
        string rootText = "√n";
        string pow2Text = "^2";
        string powText = "^";
        string sinText = "Sin";
        string cosText = "Cos";
        string tanText = "Tan";
        string percentText = "%";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.') && textBox1.Text.Length != 0)
                textBox1.AppendText(".");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && labelOperator.Text.Length != 0)
            {
                if (labelOperator.Text == plusText)
                {
                    textBox1.Text = (double.Parse(textBox2.Text) + double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == minusText)
                {
                    textBox1.Text = (double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == mulText)
                {
                    textBox1.Text = (double.Parse(textBox2.Text) * double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == divText)
                {
                    textBox1.Text = (double.Parse(textBox2.Text) / double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == sqrtText)
                {
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == rootText)
                {
                    textBox1.Text = Math.Pow(double.Parse(textBox2.Text), 1 / double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == pow2Text)
                {
                    textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                }
                else if (labelOperator.Text == powText)
                {
                    textBox1.Text = Math.Pow(double.Parse(textBox2.Text), double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == sinText)
                {
                    textBox1.Text = Math.Sin(double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == cosText)
                {
                    textBox1.Text = Math.Cos(double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == tanText)
                {
                    textBox1.Text = Math.Tan(double.Parse(textBox1.Text)).ToString();
                }
                else if (labelOperator.Text == percentText)
                {
                    textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text) / 100).ToString();
                }
                textBox2.Clear();
                labelOperator.Text = "";
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text.Length == 0)
                textBox1.Clear();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelOperator.Text = "";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = percentText;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = plusText;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = minusText;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = mulText;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = divText;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = sinText;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = cosText;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = tanText;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = sqrtText;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = rootText;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = pow2Text;
        }
    }
}
