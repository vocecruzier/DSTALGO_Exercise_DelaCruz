using System;
using System.Windows.Forms;

namespace exer3434
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);

            if (num % 2 == 0)
            {
                label1.Text = "EVEN";
            }
            else
            {
                label1.Text = "ODD";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox2.Text);

            if (num < 0)
            {
                label2.Text = "NEGATIVE";
            }
            else
            {
                label2.Text = "POSITIVE";
            }
        }
  
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            label2.Text = "";
        }
    }
}
