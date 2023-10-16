using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWeek16
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox3.Text, out double c))
            {
                label7.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            else
            {
                label7.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            label6.Text = "";
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                label6.Text = "There are no real roots";
            }
            else
            {
                double x1 = ((b * -1) + Math.Sqrt(D)) / 2 * a;
                double x2 = ((b * -1) - Math.Sqrt(D)) / 2 * a;

                label3.Text = Convert.ToString(D);
                label4.Text = Convert.ToString(x1);
                label5.Text = Convert.ToString(x2);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox3.Text, out double c))
            {
                label7.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            else
            {
                label7.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                label6.Text = "There are no real roots";
            }
            else
            {
                double x1 = ((b * -1) + Math.Sqrt(D)) / 2 * a;
                double x2 = ((b * -1) - Math.Sqrt(D)) / 2 * a;

                label3.Text = Convert.ToString(D);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox3.Text, out double c))
            {
                label7.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            else
            {
                label7.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                label6.Text = "There are no real roots";
            }
            else
            {
                double x1 = ((b * -1) + Math.Sqrt(D)) / 2 * a;
                double x2 = ((b * -1) - Math.Sqrt(D)) / 2 * a;

                label4.Text = Convert.ToString(x1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "1";
            }
            if (!double.TryParse(textBox1.Text, out double a) || !double.TryParse(textBox2.Text, out double b) || !double.TryParse(textBox3.Text, out double c))
            {
                label7.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            else
            {
                label7.Text = "";
            }
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                label6.Text = "There are no real roots";
            }
            else
            {
                double x1 = ((b * -1) + Math.Sqrt(D)) / 2 * a;
                double x2 = ((b * -1) - Math.Sqrt(D)) / 2 * a;

                label5.Text = Convert.ToString(x2);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Text = "Discriminant";
            label4.Text = "x₁";
            label5.Text = "x₂";
            label6.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
