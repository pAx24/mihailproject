using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HWeek16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int a) || !int.TryParse(textBox2.Text, out int b))
            {
                label6.Text = "You have to use numbers";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Select();
                return;
            }
            else
            {
                textBox1.Select();
                label6.Text = "";
                double num = Convert.ToDouble(textBox1.Text);
                double pow = Convert.ToDouble(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                label9.Text = label8.Text;
                if (label4.Text != "")
                {
                    label8.Text = label4.Text;
                }
                label4.Text = Convert.ToString(Math.Pow(num, pow));
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Select();
        }
    }
}
