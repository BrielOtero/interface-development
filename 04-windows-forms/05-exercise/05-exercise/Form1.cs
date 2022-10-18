namespace _05_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAndAddToLeft();
            checkSize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.SelectedItems.Contains(listBox1.Items[i]))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            checkSize();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                getAndAddToLeft();
            }
            checkSize();
        }


        private void getAndAddToLeft()
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Insert(i, listBox1.SelectedItems[i]);
            }
            checkSize();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSize();
        }

        private void checkSize()
        {
            label1.Text = "Items: " + listBox1.Items.Count.ToString();
            label2.Text = "Selected Items: " + listBox1.SelectedItems.Count.ToString();
        }
    }
}