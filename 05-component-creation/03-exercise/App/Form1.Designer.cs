namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPathSelection = new System.Windows.Forms.Button();
            this.pbImageViewer = new System.Windows.Forms.PictureBox();
            this.cbTimeBetweenImages = new System.Windows.Forms.ComboBox();
            this.mpImageShowcase = new _03_exercise.MediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPathSelection
            // 
            this.btnPathSelection.Location = new System.Drawing.Point(12, 14);
            this.btnPathSelection.Name = "btnPathSelection";
            this.btnPathSelection.Size = new System.Drawing.Size(75, 23);
            this.btnPathSelection.TabIndex = 0;
            this.btnPathSelection.Text = "Select Path";
            this.btnPathSelection.UseVisualStyleBackColor = true;
            this.btnPathSelection.Click += new System.EventHandler(this.btnPathSelection_Click);
            // 
            // pbImageViewer
            // 
            this.pbImageViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbImageViewer.Location = new System.Drawing.Point(12, 58);
            this.pbImageViewer.Name = "pbImageViewer";
            this.pbImageViewer.Size = new System.Drawing.Size(481, 380);
            this.pbImageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageViewer.TabIndex = 2;
            this.pbImageViewer.TabStop = false;
            // 
            // cbTimeBetweenImages
            // 
            this.cbTimeBetweenImages.FormattingEnabled = true;
            this.cbTimeBetweenImages.Location = new System.Drawing.Point(105, 14);
            this.cbTimeBetweenImages.Name = "cbTimeBetweenImages";
            this.cbTimeBetweenImages.Size = new System.Drawing.Size(121, 21);
            this.cbTimeBetweenImages.TabIndex = 3;
            this.cbTimeBetweenImages.SelectedIndexChanged += new System.EventHandler(this.cbTimeBetweenImages_SelectedIndexChanged);
            // 
            // mpImageShowcase
            // 
            this.mpImageShowcase.IsPlay = false;
            this.mpImageShowcase.Location = new System.Drawing.Point(244, -1);
            this.mpImageShowcase.Minutes = 0;
            this.mpImageShowcase.Name = "mpImageShowcase";
            this.mpImageShowcase.Seconds = 0;
            this.mpImageShowcase.Size = new System.Drawing.Size(176, 53);
            this.mpImageShowcase.TabIndex = 4;
            this.mpImageShowcase.PlayClick += new System.EventHandler(this.mpImageShowcase_PlayClick);
            this.mpImageShowcase.OverflowTime += new System.EventHandler(this.mpImageShowcase_OverflowTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.mpImageShowcase);
            this.Controls.Add(this.cbTimeBetweenImages);
            this.Controls.Add(this.pbImageViewer);
            this.Controls.Add(this.btnPathSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPathSelection;
        private System.Windows.Forms.PictureBox pbImageViewer;
        private System.Windows.Forms.ComboBox cbTimeBetweenImages;
        private _03_exercise.MediaPlayer mpImageShowcase;
    }
}

