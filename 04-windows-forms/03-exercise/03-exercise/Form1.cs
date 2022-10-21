namespace _03_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Image Viewer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg|*.jpg|png|*png|All files|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Bitmap image;
                try
                {
                    image = new Bitmap(filePath);

                }
                catch (Exception)
                {
                    return;
                }

                Form2 f2 = new Form2(image);
                f2.Text = openFileDialog.SafeFileName;

                if (checkBox1.Checked)
                {
                    f2.ShowDialog();
                }
                else
                {
                    f2.Show();
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want exit?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).ForeColor = Color.Red;
            }
            else
            {
                ((CheckBox)sender).ForeColor = Color.Black;
            }
        }
    }
}