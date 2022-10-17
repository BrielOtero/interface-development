﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _03_exercise
{
    public partial class Form2 : Form
    {
        public Form2(Bitmap image)
        {
            InitializeComponent();
            this.Size = image.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = image.Size;
            pictureBox1.Image = image;
        }
    }
}
