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
                                    this.chkMultiline = new System.Windows.Forms.CheckBox();
                                    this.btnType = new System.Windows.Forms.Button();
                                    this.validateTextBox = new _05_Exercise.ValidateTextBox();
                                    this.SuspendLayout();
                                    // 
                                    // chkMultiline
                                    // 
                                    this.chkMultiline.AutoSize = true;
                                    this.chkMultiline.Location = new System.Drawing.Point(12, 71);
                                    this.chkMultiline.Name = "chkMultiline";
                                    this.chkMultiline.Size = new System.Drawing.Size(64, 17);
                                    this.chkMultiline.TabIndex = 2;
                                    this.chkMultiline.Text = "Multiline";
                                    this.chkMultiline.UseVisualStyleBackColor = true;
                                    this.chkMultiline.CheckedChanged += new System.EventHandler(this.chkMultiline_CheckedChanged);
                                    // 
                                    // btnType
                                    // 
                                    this.btnType.Location = new System.Drawing.Point(12, 108);
                                    this.btnType.Name = "btnType";
                                    this.btnType.Size = new System.Drawing.Size(121, 23);
                                    this.btnType.TabIndex = 4;
                                    this.btnType.Text = "SET TEXTUAL";
                                    this.btnType.UseVisualStyleBackColor = true;
                                    this.btnType.Click += new System.EventHandler(this.btnType_Click);
                                    // 
                                    // validateTextBox
                                    // 
                                    this.validateTextBox.Location = new System.Drawing.Point(12, 12);
                                    this.validateTextBox.Multiline = false;
                                    this.validateTextBox.Name = "validateTextBox";
                                    this.validateTextBox.Size = new System.Drawing.Size(134, 40);
                                    this.validateTextBox.TabIndex = 0;
                                    this.validateTextBox.Type = _05_Exercise.eType.NUMERIC;
                                    this.validateTextBox.ValidateTextChange += new System.EventHandler(this.validateTextBox_ValidateTextChange);
                                    // 
                                    // Form1
                                    // 
                                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                                    this.ClientSize = new System.Drawing.Size(800, 450);
                                    this.Controls.Add(this.btnType);
                                    this.Controls.Add(this.chkMultiline);
                                    this.Controls.Add(this.validateTextBox);
                                    this.Name = "Form1";
                                    this.Text = "Form1";
                                    this.ResumeLayout(false);
                                    this.PerformLayout();

        }

        #endregion

        private _05_Exercise.ValidateTextBox validateTextBox;
        private System.Windows.Forms.CheckBox chkMultiline;
        private System.Windows.Forms.Button btnType;
    }
}

