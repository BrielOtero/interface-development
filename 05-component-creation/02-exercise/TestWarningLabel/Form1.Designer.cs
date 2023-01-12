namespace TestWarningLabel
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
            this.btnChangeGradient = new System.Windows.Forms.Button();
            this.cbChangeMark = new System.Windows.Forms.ComboBox();
            this.lblWarning = new _01_exercise.WarningLabel();
            this.SuspendLayout();
            // 
            // btnChangeGradient
            // 
            this.btnChangeGradient.Location = new System.Drawing.Point(33, 74);
            this.btnChangeGradient.Name = "btnChangeGradient";
            this.btnChangeGradient.Size = new System.Drawing.Size(106, 23);
            this.btnChangeGradient.TabIndex = 1;
            this.btnChangeGradient.Text = "Change Gradient";
            this.btnChangeGradient.UseVisualStyleBackColor = true;
            this.btnChangeGradient.Click += new System.EventHandler(this.btnChangeGradient_Click);
            // 
            // cbChangeMark
            // 
            this.cbChangeMark.FormattingEnabled = true;
            this.cbChangeMark.Location = new System.Drawing.Point(33, 103);
            this.cbChangeMark.Name = "cbChangeMark";
            this.cbChangeMark.Size = new System.Drawing.Size(102, 21);
            this.cbChangeMark.TabIndex = 3;
            this.cbChangeMark.SelectedIndexChanged += new System.EventHandler(this.cbChangeMark_SelectedIndexChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.HasGradient = true;
            this.lblWarning.Location = new System.Drawing.Point(33, 23);
            this.lblWarning.Mark = Test.eMark.Image;
            this.lblWarning.MarkImage = global::TestWarningLabel.Properties.Resources.copy;
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(128, 23);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "WARNING!";
            this.lblWarning.ClickOnMark += new System.EventHandler(this.lblWarning_ClickOnMark);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 189);
            this.Controls.Add(this.cbChangeMark);
            this.Controls.Add(this.btnChangeGradient);
            this.Controls.Add(this.lblWarning);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _01_exercise.WarningLabel lblWarning;
        private System.Windows.Forms.Button btnChangeGradient;
        private System.Windows.Forms.ComboBox cbChangeMark;
    }
}

