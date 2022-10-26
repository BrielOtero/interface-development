using _06_exercise.Properties;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Windows.Forms;

namespace _06_exercise
{
    public partial class Form1 : Form
    {
        private Button btn;
        private int MARGIN = 5;
        private Color DEFAULT_COLOR;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Phone";
            Pin pin = new Pin();
            if (pin.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }

            int x = 10;
            int y = 100;
            DEFAULT_COLOR = button1.BackColor;
            button1.Click += new System.EventHandler(this.btn_Click);
            button1.MouseEnter += new EventHandler(this.btn_MouseEnter);
            button1.MouseLeave += new EventHandler(this.btn_MouseLeave);

            for (int i = 0; i < 12; i++)
            {

                btn = new Button();
                btn.BackgroundImage = (Image)Resources.ResourceManager.GetObject(i + "");
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Tag = (i + 1).ToString();
                btn.Location = new Point(x, y);
                btn.Size = new Size(100, 100);
                this.btn.Click += new EventHandler(this.btn_Click);
                this.btn.MouseEnter += new EventHandler(this.btn_MouseEnter);
                this.btn.MouseLeave += new EventHandler(this.btn_MouseLeave);



                this.Controls.Add(btn);

                if ((i + 1) % 3 == 0)
                {
                    x = 10;
                    y += 100 + MARGIN;
                }
                else
                {
                    x += 100 + MARGIN;
                }
            }

        }



        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                int.TryParse(((Button)sender).Tag.ToString(), out int id);

                if (id != 13)
                {
                    ((Button)sender).BackColor = Color.RebeccaPurple;
                }

                if (id <= 9)
                {
                    textBox1.Text += id;
                }
                else
                {
                    switch (id)
                    {
                        case 10:
                            textBox1.Text += "*";
                            break;
                        case 11:
                            textBox1.Text += "0";
                            break;
                        case 12:
                            textBox1.Text += "#";
                            break;
                        case 13:
                            reset();
                            break;
                    }

                }

            }

        }



        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.RebeccaPurple)
            {
                ((Button)sender).BackColor = Color.GreenYellow;
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.RebeccaPurple)
            {
                ((Button)sender).BackColor = DEFAULT_COLOR;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            textBox1.Text = "";
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    c.BackColor = DEFAULT_COLOR;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App created by Gabriel Otero.\r19/10/2022", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void separatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newText = "";

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    newText += "-" + textBox1.Text[i];
                }
                else
                {
                    newText += textBox1.Text[i];
                }
            }

            textBox1.Text = newText;
        }

        private void saveNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Title = "Select the directory";
                saveFileDialog.InitialDirectory = "C:\\";
                saveFileDialog.Filter = "texto|*.txt";
                saveFileDialog.ValidateNames = true;
                saveFileDialog.ShowDialog();

                StreamWriter s;
                s = new StreamWriter(saveFileDialog.FileName);
                s.Write(this.textBox1.Text);
                s.Close();
            }

        }
    }

}