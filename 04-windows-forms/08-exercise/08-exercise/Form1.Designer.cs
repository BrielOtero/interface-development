namespace _08_exercise
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open";
            this.toolTip.SetToolTip(this.btnOpen, "Open File");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(800, 400);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::_08_exercise.Properties.Resources.left;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeft.Location = new System.Drawing.Point(93, 10);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(27, 27);
            this.btnLeft.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnLeft, "Previous Photo");
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::_08_exercise.Properties.Resources.right;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRight.Location = new System.Drawing.Point(126, 10);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(27, 27);
            this.btnRight.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnRight, "Next Photo");
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(170, 16);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(38, 15);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "label1";
            this.lblPath.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(426, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 15);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "label2";
            this.lblInfo.Visible = false;
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.beforeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.cmsRightClick.Name = "contextMenuStrip1";
            this.cmsRightClick.Size = new System.Drawing.Size(155, 70);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nextToolStripMenuItem.Text = "Next Photo";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // beforeToolStripMenuItem
            // 
            this.beforeToolStripMenuItem.Name = "beforeToolStripMenuItem";
            this.beforeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.beforeToolStripMenuItem.Text = "Previous Photo";
            this.beforeToolStripMenuItem.Click += new System.EventHandler(this.beforeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnOpen);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.cmsRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpen;
        private FlowLayoutPanel flowLayoutPanel;
        private Button btnLeft;
        private Button btnRight;
        private Label lblPath;
        private Label lblInfo;
        private ContextMenuStrip cmsRightClick;
        private ToolStripMenuItem nextToolStripMenuItem;
        private ToolStripMenuItem beforeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolTip toolTip;
    }
}