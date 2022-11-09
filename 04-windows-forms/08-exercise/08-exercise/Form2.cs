using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_exercise
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Bitmap image, Form1 form1)
        {
            InitializeComponent();
            this.Size = image.Size;
            this.form1=form1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void nextPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((Button)form1.Controls.Find("btnRight", false)[0]).PerformClick();
            }
            catch (ArgumentException)
            {
                Trace.WriteLine("Next photo argument exception");
            }
            catch (Exception)
            {
                Trace.WriteLine("Next photo exception");
            }
        }

        private void previousPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((Button)form1.Controls.Find("btnLeft", false)[0]).PerformClick();
            }
            catch (ArgumentException)
            {
                Trace.WriteLine("Previous photo argument exception");
            }
            catch (Exception)
            {
                Trace.WriteLine("Previous photo exception");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
