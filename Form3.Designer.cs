namespace HWeek16
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(375, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 2;
            label1.Text = "Calculator";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 73);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Coral;
            button3.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(615, 3);
            button3.Name = "button3";
            button3.Size = new Size(257, 65);
            button3.TabIndex = 3;
            button3.Text = "Quadratic Equation";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(304, 3);
            button2.Name = "button2";
            button2.Size = new Size(277, 65);
            button2.TabIndex = 2;
            button2.Text = "To The Power Of";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 3);
            button1.Name = "button1";
            button1.Size = new Size(260, 65);
            button1.TabIndex = 0;
            button1.Text = "Arithmetic Оperations";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Coral;
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 429);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 73);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.BackColor = Color.Coral;
            button5.Font = new Font("Segoe MDL2 Assets", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(3, 5);
            button5.Name = "button5";
            button5.Size = new Size(878, 65);
            button5.TabIndex = 5;
            button5.Text = "End";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tomato;
            button4.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(304, 331);
            button4.Name = "button4";
            button4.Size = new Size(277, 46);
            button4.TabIndex = 42;
            button4.Text = "ax² + bx___";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Tomato;
            button6.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ImageAlign = ContentAlignment.TopCenter;
            button6.Location = new Point(304, 279);
            button6.Name = "button6";
            button6.Size = new Size(277, 46);
            button6.TabIndex = 41;
            button6.Text = "ax²____ + c";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Tomato;
            button7.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(304, 227);
            button7.Name = "button7";
            button7.Size = new Size(277, 46);
            button7.TabIndex = 40;
            button7.Text = "_____bx + c";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Tomato;
            button8.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(304, 175);
            button8.Name = "button8";
            button8.Size = new Size(277, 46);
            button8.TabIndex = 39;
            button8.Text = "ax² + bx + c\r\n    \r\n   \r\n    ";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(884, 502);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(panel3);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}