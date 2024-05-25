namespace VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // remove the selected item
        private void button2_Click(object sender, EventArgs e)
        {
            // get number of items
            int amount = Convert.ToInt32(textBox2.Text);
            if (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            textBox2.Text = (amount - 1).ToString();
        }

        // Button "Nhập thông tin"
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox2.Text = listBox1.Items.Count.ToString();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(0);
            textBox2.Text = (amount - 1).ToString();
        }

        //remove all items
        private void button4_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox2.Text);
            listBox1.Items.Clear();
            textBox2.Text = (amount - 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(textBox2.Text);
            listBox1.Items.RemoveAt(amount - 1);
            textBox2.Text = (amount - 1).ToString();
        }
    }
}
