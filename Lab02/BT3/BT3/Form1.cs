namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (checkBox1.Checked)
            {
                result += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked)
            {
                result += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked)
            {
                result += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked)
            {
                result += checkBox4.Text + "\n";
            }
            if (checkBox5.Checked)
            {
                result += checkBox5.Text + "\n";
            }
            if (result.Length > 0)
            {
                MessageBox.Show("Sở thích của bạn là: \n" + result);
            }
            else MessageBox.Show("Không có sở thích nào mà bạn chọn!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            if (radioButton1.Checked) result = radioButton1.Text + "\n";
            if (radioButton2.Checked) result = radioButton2.Text + "\n";
            if (radioButton3.Checked) result = radioButton3.Text + "\n";
            if (radioButton4.Checked) result = radioButton4.Text + "\n";
            if (radioButton5.Checked) result = radioButton5.Text + "\n";
            if (result.Length > 0) MessageBox.Show("Màu bạn thích là: \n" + result);
            else MessageBox.Show("Không có màu nào bạn chọn!!");

        }
    }
}
