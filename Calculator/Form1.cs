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
        string plusText = "บวกกับ";
        string minusText = "ลบกับ";
        string mulText = "คูณกับ";
        string divText = "หารกับ";
        string sqrtText = "รากที่สอง";
        string rootText = "รากที่";
        string pow2Text = "ยกกำลังสอง";
        string powText = "ยกกำลังกับ";
        string sinText = "ไซน์";
        string cosText = "โคไซน์";
        string tanText = "แทนเจนต์";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = plusText;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = minusText;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = mulText;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = divText;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = rootText;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            if (textBox2.Text.Length != 0)
                labelOperator.Text = powText;
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

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = sqrtText;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelOperator.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.') && textBox1.Text.Length != 0)
                textBox1.AppendText(".");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text.Length == 0)
                textBox1.Clear();
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

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button26_Click(object sender, EventArgs e) // =
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
                textBox2.Clear();
                labelOperator.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = pow2Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = sinText;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = cosText;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                textBox1.Text = textBox2.Text;
                textBox2.Clear();
            }
            if (textBox1.Text.Length != 0)
                labelOperator.Text = tanText;
        }
    }
}
