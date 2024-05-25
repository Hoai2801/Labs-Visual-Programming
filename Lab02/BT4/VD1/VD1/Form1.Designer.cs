namespace VD1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(64, 22);
            label1.Name = "label1";
            label1.Size = new Size(481, 59);
            label1.TabIndex = 0;
            label1.Text = "KHAI BÁO Y TẾ ĐIỆN TỬ";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 352);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(64, 71);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 2;
            button1.Text = "Nhập thông tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(241, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 154);
            listBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 273);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 3;
            label3.Text = "Tổng số người đã khai báo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(394, 270);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(241, 308);
            button2.Name = "button2";
            button2.Size = new Size(159, 23);
            button2.TabIndex = 5;
            button2.Text = "Xoá thông tin đang chọn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(406, 308);
            button3.Name = "button3";
            button3.Size = new Size(152, 23);
            button3.TabIndex = 6;
            button3.Text = "Xoá thông tin đầu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(241, 337);
            button4.Name = "button4";
            button4.Size = new Size(159, 23);
            button4.TabIndex = 7;
            button4.Text = "Xoá tất cả thông tin";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(406, 337);
            button5.Name = "button5";
            button5.Size = new Size(152, 23);
            button5.TabIndex = 8;
            button5.Text = "Xoá thông tin cuối";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 383);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
