namespace HWeek16
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label12 = new Label();
            button17 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Tomato;
            button5.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(77, 374);
            button5.Name = "button5";
            button5.Size = new Size(293, 48);
            button5.TabIndex = 60;
            button5.Text = "Clear";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(77, 218);
            button1.Name = "button1";
            button1.Size = new Size(293, 42);
            button1.TabIndex = 54;
            button1.Text = "Calculate x₁";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 291);
            label1.Name = "label1";
            label1.Size = new Size(35, 31);
            label1.TabIndex = 52;
            label1.Text = "x₁";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Coral;
            textBox2.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(254, 89);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "c";
            textBox2.Size = new Size(37, 47);
            textBox2.TabIndex = 51;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Coral;
            textBox1.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(149, 90);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "b";
            textBox1.Size = new Size(37, 47);
            textBox1.TabIndex = 50;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(180, 94);
            label2.Name = "label2";
            label2.Size = new Size(75, 40);
            label2.TabIndex = 48;
            label2.Text = "x  +";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe MDL2 Assets", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(162, 22);
            label12.Name = "label12";
            label12.Size = new Size(125, 38);
            label12.TabIndex = 47;
            label12.Text = "bx  +  c";
            // 
            // button17
            // 
            button17.BackColor = Color.Tomato;
            button17.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(77, 439);
            button17.Name = "button17";
            button17.Size = new Size(293, 48);
            button17.TabIndex = 46;
            button17.Text = "Back";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 157);
            label3.Name = "label3";
            label3.Size = new Size(254, 24);
            label3.TabIndex = 61;
            label3.Text = "You can only use numbers";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(442, 502);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(button17);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label12;
        private Button button17;
        private Label label3;
    }
}