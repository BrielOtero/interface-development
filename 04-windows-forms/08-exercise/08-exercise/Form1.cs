using System.Diagnostics;
using System.Windows.Forms;

namespace _08_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] images = di.GetFiles("*.jpg,*.png,*.jpeg,*.bmp");
                Trace.WriteLine(images.Length);
                foreach (var image in images)
                {
                    createPictureBox(new Bitmap(image.FullName));
                    Trace.WriteLine(image.FullName);
                }

            }
        }
        private void createPictureBox(Bitmap image)
        {
    PictureBox pb;

        pb = new PictureBox();
            pb.Size = new Size(200, 200);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = image;
            pb.Visible = true;

            flowLayoutPanel1.Controls.Add(pb);
        }
    }
}