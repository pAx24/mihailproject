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

namespace HWeek16
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label3.Text = "";
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
            b = Convert.ToDouble(textBox1.Text);
            c = Convert.ToDouble(textBox2.Text);
            label1.Text = Convert.ToString(-1 * (c / b));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "x₁";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
    }
}
