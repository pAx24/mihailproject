namespace HWeek16
{
    partial class Form7
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
            button3 = new Button();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            button5 = new Button();
            button1 = new Button();
            label1 = new Label();
            button17 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label22 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(36, 198);
            button3.Name = "button3";
            button3.Size = new Size(370, 42);
            button3.TabIndex = 80;
            button3.Text = "Calculate All";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(95, 134);
            label3.Name = "label3";
            label3.Size = new Size(254, 24);
            label3.TabIndex = 79;
            label3.Text = "You can only use numbers";
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(36, 313);
            button2.Name = "button2";
            button2.Size = new Size(143, 42);
            button2.TabIndex = 78;
            button2.Text = "Calculate x₂";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 313);
            label2.Name = "label2";
            label2.Size = new Size(35, 31);
            label2.TabIndex = 77;
            label2.Text = "x₂";
            // 
            // button5
            // 
            button5.BackColor = Color.Tomato;
            button5.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(77, 377);
            button5.Name = "button5";
            button5.Size = new Size(293, 48);
            button5.TabIndex = 76;
            button5.Text = "Clear";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(36, 255);
            button1.Name = "button1";
            button1.Size = new Size(143, 42);
            button1.TabIndex = 75;
            button1.Text = "Calculate x₁";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 255);
            label1.Name = "label1";
            label1.Size = new Size(35, 31);
            label1.TabIndex = 74;
            label1.Text = "x₁";
            // 
            // button17
            // 
            button17.BackColor = Color.Tomato;
            button17.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(77, 442);
            button17.Name = "button17";
            button17.Size = new Size(293, 48);
            button17.TabIndex = 73;
            button17.Text = "Back";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Coral;
            textBox2.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(232, 73);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "c";
            textBox2.Size = new Size(45, 47);
            textBox2.TabIndex = 72;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Coral;
            textBox1.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(126, 71);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "a";
            textBox1.Size = new Size(46, 47);
            textBox1.TabIndex = 71;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe MDL2 Assets", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(167, 76);
            label22.Name = "label22";
            label22.Size = new Size(138, 40);
            label22.TabIndex = 70;
            label22.Text = "x² +    x";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe MDL2 Assets", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(154, 12);
            label12.Name = "label12";
            label12.Size = new Size(130, 38);
            label12.TabIndex = 69;
            label12.Text = "ax² + bx";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(442, 502);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button17);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label22);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label3;
        private Button button2;
        private Label label2;
        private Button button5;
        private Button button1;
        private Label label1;
        private Button button17;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label22;
        private Label label12;
    }
}