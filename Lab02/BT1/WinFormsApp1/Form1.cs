﻿namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên của bạn là: " + lb_textBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
