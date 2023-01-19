namespace App
{
    partial class Configuration
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
            this.cboColumns = new System.Windows.Forms.ComboBox();
            this.rbColumns = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.lstColors = new System.Windows.Forms.ListBox();
            this.lblTypeInfo = new System.Windows.Forms.Label();
            this.lblColumnsInfo = new System.Windows.Forms.Label();
            this.lblLineColorInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboColumns
            // 
            this.cboColumns.FormattingEnabled = true;
            this.cboColumns.Location = new System.Drawing.Point(12, 124);
            this.cboColumns.Name = "cboColumns";
            this.cboColumns.Size = new System.Drawing.Size(133, 21);
            this.cboColumns.TabIndex = 0;
            this.cboColumns.SelectedIndexChanged += new System.EventHandler(this.cboColumns_SelectedIndexChanged);
            // 
            // rbColumns
            // 
            this.rbColumns.AutoSize = true;
            this.rbColumns.Location = new System.Drawing.Point(15, 37);
            this.rbColumns.Name = "rbColumns";
            this.rbColumns.Size = new System.Drawing.Size(65, 17);
            this.rbColumns.TabIndex = 1;
            this.rbColumns.TabStop = true;
            this.rbColumns.Text = "Columns";
            this.rbColumns.UseVisualStyleBackColor = true;
            this.rbColumns.CheckedChanged += new System.EventHandler(this.rbTypes_CheckedChanged);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(15, 60);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.CheckedChanged += new System.EventHandler(this.rbTypes_CheckedChanged);
            // 
            // lstColors
            // 
            this.lstColors.FormattingEnabled = true;
            this.lstColors.Location = new System.Drawing.Point(214, 37);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(120, 108);
            this.lstColors.TabIndex = 3;
            this.lstColors.SelectedIndexChanged += new System.EventHandler(this.lstColors_SelectedIndexChanged);
            // 
            // lblTypeInfo
            // 
            this.lblTypeInfo.AutoSize = true;
            this.lblTypeInfo.Location = new System.Drawing.Point(12, 9);
            this.lblTypeInfo.Name = "lblTypeInfo";
            this.lblTypeInfo.Size = new System.Drawing.Size(92, 13);
            this.lblTypeInfo.TabIndex = 4;
            this.lblTypeInfo.Text = "Change type view";
            // 
            // lblColumnsInfo
            // 
            this.lblColumnsInfo.AutoSize = true;
            this.lblColumnsInfo.Location = new System.Drawing.Point(9, 97);
            this.lblColumnsInfo.Name = "lblColumnsInfo";
            this.lblColumnsInfo.Size = new System.Drawing.Size(136, 13);
            this.lblColumnsInfo.TabIndex = 5;
            this.lblColumnsInfo.Text = "Change number of columns";
            // 
            // lblLineColorInfo
            // 
            this.lblLineColorInfo.AutoSize = true;
            this.lblLineColorInfo.Location = new System.Drawing.Point(211, 9);
            this.lblLineColorInfo.Name = "lblLineColorInfo";
            this.lblLineColorInfo.Size = new System.Drawing.Size(89, 13);
            this.lblLineColorInfo.TabIndex = 6;
            this.lblLineColorInfo.Text = "Change line color";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(322, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save && Apply Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 243);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLineColorInfo);
            this.Controls.Add(this.lblColumnsInfo);
            this.Controls.Add(this.lblTypeInfo);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.rbLine);
            this.Controls.Add(this.rbColumns);
            this.Controls.Add(this.cboColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboColumns;
        private System.Windows.Forms.RadioButton rbColumns;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.ListBox lstColors;
        private System.Windows.Forms.Label lblTypeInfo;
        private System.Windows.Forms.Label lblColumnsInfo;
        private System.Windows.Forms.Label lblLineColorInfo;
        private System.Windows.Forms.Button btnSave;
    }
}