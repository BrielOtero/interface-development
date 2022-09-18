namespace _05_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            if (title.Trim() != "")
            {
                DialogResult result;
                result =MessageBox.Show(this,"Do you set \"" + title + "\" as title?","Change title", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(result == DialogResult.Yes)
                {
                    Text = title;        
                }
            }
        }


    }
}