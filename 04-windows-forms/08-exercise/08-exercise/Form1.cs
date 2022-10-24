using System.Diagnostics;
using System.Windows.Forms;

namespace _08_exercise
{
    public partial class Form1 : Form
    {
        private string[] allowedExtensions = new string[] { "*.png", "*.jpg", "*.jpeg" };
        private FolderBrowserDialog fbd;
        private DirectoryInfo di;
        private List<FileInfo> imagesInfo = new List<FileInfo>();
        private List<Bitmap> images = new List<Bitmap>();
        private Form2 form2;
        private int selectedImage = 0;
        private List<Control> picturesBox = new List<Control>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Images Viewer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                clearForm();
                di = new DirectoryInfo(fbd.SelectedPath);
                Trace.WriteLine(fbd.SelectedPath);
                imagesInfo = allowedExtensions.SelectMany(i => di.GetFiles(i, SearchOption.TopDirectoryOnly)).ToList();
                Trace.WriteLine(imagesInfo.Count);

                for (int i = imagesInfo.Count - 1; i >= 0; i--)
                {
                    Bitmap imagePhoto = getBitmap(imagesInfo.ElementAt(i).FullName);

                    if (imagePhoto != null)
                    {
                        images.Insert(0, imagePhoto);
                        createPictureBox(imagePhoto, i);
                    }
                    else
                    {
                        imagesInfo[i].Delete();
                    }
                }

                if (images.Count <= 0) return;
                flowLayoutPanel1.Controls.AddRange(picturesBox.ToArray());

                Trace.WriteLine(imagesInfo.Count);

                form2 = new Form2(images.ElementAt(selectedImage));
                form2.Text = imagesInfo.ElementAt(selectedImage).Name;
                form2.Show();

                button2.Visible = true;
                button3.Visible = true;
                update_labels();
                label1.Visible = true;
                label2.Visible = true;


            }
        }
        private void createPictureBox(Bitmap image, int tag)
        {
            PictureBox pb;

            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.ContextMenuStrip = contextMenuStrip1;
            pb.Image = image;
            pb.Tag = tag;
            pb.MouseClick += Pb_MouseClick;
            pb.Visible = true;

            picturesBox.Insert(0, pb);
        }

        private void Pb_MouseClick(object sender, MouseEventArgs e)
        {
            selectedImage = (int)((PictureBox)sender).Tag;
            changeImageAndTitleForm2((int)((PictureBox)sender).Tag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeImageForm2(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeImageForm2(false);
        }

        private void changeImageForm2(bool isLeft)
        {
            if (imagesInfo == null) return;

            if ((selectedImage < imagesInfo.Count - 1 && !isLeft) || (isLeft && selectedImage > 0))
            {
                selectedImage = isLeft ? selectedImage - 1 : selectedImage + 1;

                changeImageAndTitleForm2();
            }
        }

        private void changeImageAndTitleForm2()
        {
            changeImageAndTitleForm2(selectedImage);
        }

        private void changeImageAndTitleForm2(int index)
        {
            form2.Text = imagesInfo.ElementAt(index).Name;
            form2.pictureBox1.Image = images.ElementAt(index);
            update_labels();

        }

        private Bitmap getBitmap(string path)
        {
            try
            {
                Bitmap imagePhoto1 = new Bitmap(path);
                return imagePhoto1;

            }
            catch (ArgumentException)
            {
                Trace.WriteLine("Image Photo Argument Exception");
            }
            catch
            {
                Trace.WriteLine("Image Photo Exception");
            }

            return null;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                changeImageForm2(true);
            }

            if (e.KeyCode == Keys.D)
            {
                changeImageForm2(false);
            }
        }

        private void update_labels()
        {
            if (imagesInfo != null)
            {
                label1.Text = imagesInfo.ElementAt(selectedImage).Directory.ToString();
                label2.Text = $"Name: {imagesInfo.ElementAt(selectedImage).Name}\nSize: {convertBytes(imagesInfo.ElementAt(selectedImage).Length)}\nResolution: {images.ElementAt(selectedImage).Width}x{images.ElementAt(selectedImage).Height}";
            }
        }

        private string convertBytes(long bytes)
        {
            return bytes > 1000000 ? bytes / 1000000 + " Mb" : bytes / 1000 + " Kb";
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeImageForm2(false);
        }

        private void beforeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeImageForm2(true);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            selectedImage = 0;
            images.Clear();
            if (form2 != null)
            {
                form2.Close();
            }
            imagesInfo.Clear();
            flowLayoutPanel1.Controls.Clear();
            picturesBox.Clear();
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to close the app?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}