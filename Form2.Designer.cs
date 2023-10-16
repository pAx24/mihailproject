namespace HWeek16
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button17 = new Button();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 34);
            label1.TabIndex = 0;
            label1.Text = "Number:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Coral;
            textBox1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(236, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 45);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(218, 34);
            label2.TabIndex = 2;
            label2.Text = "To the power of:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Coral;
            textBox2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(236, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 45);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 282);
            label3.Name = "label3";
            label3.Size = new Size(113, 34);
            label3.TabIndex = 4;
            label3.Text = "Answer:";
            // 
            // button17
            // 
            button17.BackColor = Color.Tomato;
            button17.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(77, 417);
            button17.Name = "button17";
            button17.Size = new Size(293, 48);
            button17.TabIndex = 29;
            button17.Text = "Back";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 284);
            label4.Name = "label4";
            label4.Size = new Size(0, 34);
            label4.TabIndex = 30;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(236, 283);
            button2.Name = "button2";
            button2.Size = new Size(169, 48);
            button2.TabIndex = 31;
            button2.Text = "Calculate";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe MDL2 Assets", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(121, 326);
            label8.Name = "label8";
            label8.Size = new Size(0, 22);
            label8.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(123, 357);
            label9.Name = "label9";
            label9.Size = new Size(0, 16);
            label9.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 37;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(442, 502);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button17);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button17;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label6;
    }
}