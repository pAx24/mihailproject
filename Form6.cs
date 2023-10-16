using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HWeek16
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox2.Text, out double c))
            {
                label3.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            else
            {
                label3.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(Math.Sqrt(-1 * (c / a)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox2.Text, out double c))
            {
                label3.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            else
            {
                label3.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox2.Text);
            label2.Text = Convert.ToString(-1 * Math.Sqrt(-1 * (c / a)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label1.Text = "x₁";
            label2.Text = "x₂";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox2.Text, out double c))
            {
                label3.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            else
            {
                label3.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(Math.Sqrt(-1 * (c / a)));
            label2.Text = Convert.ToString(-1 * Math.Sqrt(-1 * (c / a)));
        }
    }
}
