namespace HWeek16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool prom = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
        private void TB1(object sender, EventArgs e)
        {
            prom = true;
        }

        private void TB3(object sender, EventArgs e)
        {
            prom = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "0";
            }
            else if (prom)
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox3.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "1";
            }
            else if (prom)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox3.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "2";
            }
            else if (prom)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox3.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "3";
            }
            else if (prom)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox3.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "4";
            }
            else if (prom)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox3.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "5";
            }
            else if (prom)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox3.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "6";
            }
            else if (prom)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox3.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "7";
            }
            else if (prom)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox3.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "8";
            }
            else if (prom)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox3.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                textBox3.Text += "9";
            }
            else if (prom)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox3.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label2.Text != "Answer")
            {
                textBox3.Text = "";
                if (textBox1.Text != "")
                {
                    textBox1.Text = label2.Text;
                }
                label1.Text = "+";
            }
            else
            {
                label1.Text = "+";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label2.Text != "Answer")
            {
                textBox3.Text = "";
                textBox1.Text = label2.Text;
                label1.Text = "-";
            }
            else
            {
                label1.Text = "-";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label2.Text != "Answer")
            {
                textBox3.Text = "";
                textBox1.Text = label2.Text;
                label1.Text = "X";
            }
            else
            {
                label1.Text = "X";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label2.Text != "Answer")
            {
                textBox3.Text = "";
                textBox1.Text = label2.Text;
                label1.Text = "/";
            }
            else
            {
                label1.Text = "/";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out int a) || !int.TryParse(textBox3.Text, out int b))
            {
                textBox1.Select();
                label3.Text = "You can only use numbers";
                textBox1.Text = "";
                textBox3.Text = "";
                return;
            }
            else
            {
                label3.Text = "";
            }

            if (label1.Text == "+")
            {
                label2.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox3.Text)).ToString();
            }
            else if (label1.Text == "-")
            {
                label2.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox3.Text)).ToString();
            }
            else if (label1.Text == "X")
            {
                label2.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox3.Text)).ToString();
            }
            else if (label1.Text == "/")
            {
                label2.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox3.Text)).ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            label3.Text = "";
            label5.Text = label4.Text;
            if (label2.Text != "Answer")
            {
                label4.Text = label2.Text;
            }
            textBox1.Text = "";
            label1.Text = "";
            textBox3.Text = "";
            label2.Text = "Answer";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}