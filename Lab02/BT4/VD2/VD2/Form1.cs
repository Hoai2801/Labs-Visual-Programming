namespace VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yellow")
            {
                label1.BackColor = Color.Red;
                label1.ForeColor = Color.Yellow;
            }
            if (comboBox1.Text == "Red")
            {
                label1.BackColor = Color.Yellow;
                label1.ForeColor = Color.Red;
            }
            if (comboBox1.Text == "Blue")
            {
                label1.BackColor = Color.Yellow;
                label1.ForeColor = Color.Blue;
            }
            if (comboBox1.Text == "Black")
            {
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }
        }
    }
}
