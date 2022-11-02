namespace _05_exercise
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
            this.components = new System.ComponentModel.Container();
            this.listBoxLeft = new System.Windows.Forms.ListBox();
            this.listBoxRight = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRem = new System.Windows.Forms.Button();
            this.buttonTransRight = new System.Windows.Forms.Button();
            this.buttonTransLeft = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBoxLeft
            // 
            this.listBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLeft.FormattingEnabled = true;
            this.listBoxLeft.ItemHeight = 15;
            this.listBoxLeft.Location = new System.Drawing.Point(-1, -2);
            this.listBoxLeft.Name = "listBoxLeft";
            this.listBoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxLeft.Size = new System.Drawing.Size(120, 454);
            this.listBoxLeft.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listBoxLeft, "Left Box");
            this.listBoxLeft.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxRight
            // 
            this.listBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRight.FormattingEnabled = true;
            this.listBoxRight.ItemHeight = 15;
            this.listBoxRight.Location = new System.Drawing.Point(265, -2);
            this.listBoxRight.Name = "listBoxRight";
            this.listBoxRight.Size = new System.Drawing.Size(120, 454);
            this.listBoxRight.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(125, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.buttonAdd, "Add");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRem
            // 
            this.buttonRem.Location = new System.Drawing.Point(126, 70);
            this.buttonRem.Name = "buttonRem";
            this.buttonRem.Size = new System.Drawing.Size(133, 23);
            this.buttonRem.TabIndex = 3;
            this.buttonRem.Text = "&Remove";
            this.toolTip1.SetToolTip(this.buttonRem, "Remove");
            this.buttonRem.UseVisualStyleBackColor = true;
            this.buttonRem.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTransRight
            // 
            this.buttonTransRight.Location = new System.Drawing.Point(125, 99);
            this.buttonTransRight.Name = "buttonTransRight";
            this.buttonTransRight.Size = new System.Drawing.Size(133, 23);
            this.buttonTransRight.TabIndex = 4;
            this.buttonTransRight.Text = "Transfer &Right ->>";
            this.buttonTransRight.UseVisualStyleBackColor = true;
            this.buttonTransRight.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonTransLeft
            // 
            this.buttonTransLeft.Location = new System.Drawing.Point(125, 128);
            this.buttonTransLeft.Name = "buttonTransLeft";
            this.buttonTransLeft.Size = new System.Drawing.Size(133, 23);
            this.buttonTransLeft.TabIndex = 5;
            this.buttonTransLeft.Text = "<<- Transfer &Left";
            this.buttonTransLeft.UseVisualStyleBackColor = true;
            this.buttonTransLeft.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBox1, "Element");
            // 
            // lblItems
            // 
            this.lblItems.Location = new System.Drawing.Point(125, 164);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(133, 23);
            this.lblItems.TabIndex = 7;
            this.lblItems.Text = "Items: 0";
            this.toolTip1.SetToolTip(this.lblItems, "Items Left");
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.Location = new System.Drawing.Point(126, 187);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(133, 254);
            this.lblSelectedItems.TabIndex = 8;
            this.lblSelectedItems.Text = "Selected Items: ";
            this.toolTip1.SetToolTip(this.lblSelectedItems, "Selected Items");
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.lblSelectedItems);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTransLeft);
            this.Controls.Add(this.buttonTransRight);
            this.Controls.Add(this.buttonRem);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxRight);
            this.Controls.Add(this.listBoxLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, "Form");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxLeft;
        private ListBox listBoxRight;
        private Button buttonAdd;
        private Button buttonRem;
        private Button buttonTransRight;
        private Button buttonTransLeft;
        private TextBox textBox1;
        private Label lblItems;
        private Label lblSelectedItems;
        private ToolTip toolTip1;
    }
}