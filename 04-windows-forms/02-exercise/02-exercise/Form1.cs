using System.Diagnostics;

namespace _02_exercise
{
    public partial class Form1 : Form
    {
        private Color defaultColor;
        public Form1()
        {
            InitializeComponent();
            defaultColor = color.BackColor;
            this.Text = "Exercise 2";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void color_Click(object sender, EventArgs e)
        {
            changeColor();
        }

        private void background_Click(object sender, EventArgs e)
        {
            changeBackground();
        }

        private void buttons_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Aquamarine;
        }

        private void buttons_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = defaultColor;
        }

        private void closeForm()
        {
            if (MessageBox.Show("Are you sure you want exit?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void changeColor()
        {
            bool correct = true;
            byte red = 0, green = 0, blue = 0;

            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                correct = byte.TryParse(textBox1.Text.ToString(), out red);

                if (correct)
                {
                    correct = byte.TryParse(textBox2.Text.ToString(), out green);
                }

                if (correct)
                {
                    correct = byte.TryParse(textBox3.Text.ToString(), out blue);;
                }
            }
            else
            {
                correct = false;
            }

            if (correct)
            {
                this.BackColor = Color.FromArgb(red, green, blue);
            }
            else
            {
                MessageBox.Show("Values no are valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeBackground()
        {
            try
            {
                label1.Image = new Bitmap(textBox4.Text);
            }
            catch (ArgumentException)
            {
                Trace.WriteLine("error with background");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeForm();
        }

        private void enterChanged(object sender, EventArgs e)
        {
            this.AcceptButton = ((TextBox)sender).Tag.ToString() == "3" ? image : color;
        }
    }
}