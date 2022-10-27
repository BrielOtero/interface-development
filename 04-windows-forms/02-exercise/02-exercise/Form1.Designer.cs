namespace _02_exercise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(643, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "&Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.buttons_Enter);
            this.exit.MouseLeave += new System.EventHandler(this.buttons_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "0";
            this.textBox1.Enter += new System.EventHandler(this.enterChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "1";
            this.textBox2.Enter += new System.EventHandler(this.enterChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Tag = "2";
            this.textBox3.Enter += new System.EventHandler(this.enterChanged);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(6, 114);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(125, 23);
            this.color.TabIndex = 4;
            this.color.Text = "&Change Background";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            this.color.MouseEnter += new System.EventHandler(this.buttons_Enter);
            this.color.MouseLeave += new System.EventHandler(this.buttons_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(212, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(385, 23);
            this.textBox4.TabIndex = 5;
            this.textBox4.Tag = "3";
            this.textBox4.Enter += new System.EventHandler(this.enterChanged);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(643, 113);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(86, 23);
            this.image.TabIndex = 0;
            this.image.Text = "&Load Image";
            this.image.UseVisualStyleBackColor = true;
            this.image.Click += new System.EventHandler(this.background_Click);
            this.image.MouseEnter += new System.EventHandler(this.buttons_Enter);
            this.image.MouseLeave += new System.EventHandler(this.buttons_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 81);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "RED";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "BLUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "GREEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "INSERT PATH";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(741, 176);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.color);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button color;
        private TextBox textBox4;
        private Button image;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}