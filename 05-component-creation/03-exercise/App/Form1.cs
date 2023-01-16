using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace App
{
    public partial class Form1 : Form
    {
        private string[] allowedExtensions = new string[] { "*.png", "*.jpg", "*.jpeg" };
        private List<FileInfo> filesInfo;
        private List<Bitmap> imagesBitmap;
        private Timer timer;
        private int imageIndex = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Exercise 3";

            for (int i = 1; i < 21; i++)
            {
                cbTimeBetweenImages.Items.Add(i);
            }
            timer = new Timer();
            timer.Tick += new EventHandler(timerEventProcessor);
            cbTimeBetweenImages.SelectedIndex = 0;
            imagesBitmap = new List<Bitmap>();
            filesInfo = new List<FileInfo>();
        }

        private void btnPathSelection_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                if (di.Exists)
                {
                    filesInfo = allowedExtensions.SelectMany(i => di.GetFiles(i, SearchOption.TopDirectoryOnly)).ToList();
                    if (filesInfo.Count > 0)
                    {
                        imagesBitmap.Clear();
                        filesInfo.ForEach(x => imagesBitmap.Add(new Bitmap(x.FullName)));
                        imageIndex = 0;
                    }
                }
            }
        }


        private void timerEventProcessor(object sender, EventArgs e)
        {
            mpImageShowcase.Seconds += 1;
            if (imagesBitmap.Count > 0)
            {
                imageIndex = imageIndex >= filesInfo.Count ? 0 : imageIndex;
                pbImageViewer.Image = imagesBitmap[imageIndex];
                imageIndex++;

            }
        }

        private void cbTimeBetweenImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(cbTimeBetweenImages.SelectedItem.ToString()) * 1000;
        }

        private void mpImageShowcase_PlayClick(object sender, EventArgs e)
        {
            if (mpImageShowcase.IsPlay)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void mpImageShowcase_OverflowTime(object sender, EventArgs e)
        {
            mpImageShowcase.Minutes += 1;
        }
    }
}
