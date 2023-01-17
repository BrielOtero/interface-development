namespace _05_Exercise
{
    partial class ValidateTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(10, 10);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(100, 20);
            this.txtText.TabIndex = 0;
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // ValidateTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtText);
            this.Name = "ValidateTextBox";
            this.Size = new System.Drawing.Size(121, 40);
            this.SizeChanged += new System.EventHandler(this.ValidateTextBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
    }
}
