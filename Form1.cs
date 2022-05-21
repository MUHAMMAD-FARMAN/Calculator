using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class form1 : Form
    {
        float num1;
        float num2;
        char Operation;


        public form1()
        {
            InitializeComponent();
        }


        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Operation = '+';
            num1 = float.Parse(label1.Text);
            label1.Text = label1.Text + "+";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Operation = '-';
            num1 = float.Parse(label1.Text);
            label1.Text = label1.Text + "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation = 'X';
            num1 = float.Parse(label1.Text);
            label1.Text = label1.Text + "X";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation = '/';
            num1 = float.Parse(label1.Text);
            label1.Text = label1.Text + "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num2 = getNum2();
            if (Operation == '+')
            {
                label2.Text = (num1 + num2).ToString();

            }
            else if (Operation == '-')
            {
                label2.Text = (num1 - num2).ToString();
            }
            else if (Operation == 'X')
            {
                label2.Text = (num1 * num2).ToString();
            }
            else if (Operation == '/')
            {
                label2.Text = (num1 / num2).ToString();
            }

        }
        public float getNum2()
        {
            string num = "";
            bool flag = false;
            for (int i = 0; i < label1.Text.Length; i++)
            {

                if (flag)
                {
                    num = num + label1.Text[i];
                }
                if (label1.Text[i] == Operation)
                {
                    flag = true;
                }
            }

            float n2 = float.Parse(num);
            return n2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = oneCharDecreaser();

        }
        public string oneCharDecreaser()
        {
            string label1Text = "";
            for(int i = 0; i < label1.Text.Length -1; i++)
            {
                label1Text = label1Text + label1.Text[i];
            }
            return label1Text;
        }
    }
}
