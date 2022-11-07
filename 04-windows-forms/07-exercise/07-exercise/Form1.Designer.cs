namespace _07_exercise
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
            this.cbxSubjects = new System.Windows.Forms.ComboBox();
            this.cbxStudents = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxSubjects
            // 
            this.cbxSubjects.FormattingEnabled = true;
            this.cbxSubjects.Location = new System.Drawing.Point(191, 12);
            this.cbxSubjects.Name = "cbxSubjects";
            this.cbxSubjects.Size = new System.Drawing.Size(173, 23);
            this.cbxSubjects.TabIndex = 0;
            this.cbxSubjects.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // cbxStudents
            // 
            this.cbxStudents.FormattingEnabled = true;
            this.cbxStudents.Location = new System.Drawing.Point(12, 12);
            this.cbxStudents.Name = "cbxStudents";
            this.cbxStudents.Size = new System.Drawing.Size(173, 23);
            this.cbxStudents.TabIndex = 1;
            this.cbxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // lblTableInfo
            // 
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Location = new System.Drawing.Point(370, 15);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(0, 15);
            this.lblTableInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTableInfo);
            this.Controls.Add(this.cbxStudents);
            this.Controls.Add(this.cbxSubjects);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxSubjects;
        private ComboBox cbxStudents;
        private ToolTip toolTip1;
        private Label lblTableInfo;
    }
}