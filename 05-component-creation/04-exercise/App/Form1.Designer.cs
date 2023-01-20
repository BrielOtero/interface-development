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
                                    this.drawHanged = new _04_exercise.DrawHanged();
                                    this.btnDecrement = new System.Windows.Forms.Button();
                                    this.btnIncrement = new System.Windows.Forms.Button();
                                    this.lblMistakes = new System.Windows.Forms.Label();
                                    this.SuspendLayout();
                                    // 
                                    // drawHanged
                                    // 
                                    this.drawHanged.Location = new System.Drawing.Point(12, 12);
                                    this.drawHanged.Mistakes = 2;
                                    this.drawHanged.Name = "drawHanged";
                                    this.drawHanged.Size = new System.Drawing.Size(183, 160);
                                    this.drawHanged.TabIndex = 0;
                                    this.drawHanged.MistakesChanged += new System.EventHandler(this.drawHanged_MistakesChanged);
                                    this.drawHanged.Hanged += new System.EventHandler(this.drawHanged_Hanged);
                                    // 
                                    // btnDecrement
                                    // 
                                    this.btnDecrement.Location = new System.Drawing.Point(12, 269);
                                    this.btnDecrement.Name = "btnDecrement";
                                    this.btnDecrement.Size = new System.Drawing.Size(75, 23);
                                    this.btnDecrement.TabIndex = 1;
                                    this.btnDecrement.Text = "-";
                                    this.btnDecrement.UseVisualStyleBackColor = true;
                                    this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
                                    // 
                                    // btnIncrement
                                    // 
                                    this.btnIncrement.Location = new System.Drawing.Point(93, 269);
                                    this.btnIncrement.Name = "btnIncrement";
                                    this.btnIncrement.Size = new System.Drawing.Size(75, 23);
                                    this.btnIncrement.TabIndex = 2;
                                    this.btnIncrement.Text = "+";
                                    this.btnIncrement.UseVisualStyleBackColor = true;
                                    this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
                                    // 
                                    // lblMistakes
                                    // 
                                    this.lblMistakes.AutoSize = true;
                                    this.lblMistakes.Location = new System.Drawing.Point(12, 240);
                                    this.lblMistakes.Name = "lblMistakes";
                                    this.lblMistakes.Size = new System.Drawing.Size(49, 13);
                                    this.lblMistakes.TabIndex = 3;
                                    this.lblMistakes.Text = "Mistakes";
                                    // 
                                    // Form1
                                    // 
                                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                                    this.ClientSize = new System.Drawing.Size(800, 450);
                                    this.Controls.Add(this.lblMistakes);
                                    this.Controls.Add(this.btnIncrement);
                                    this.Controls.Add(this.btnDecrement);
                                    this.Controls.Add(this.drawHanged);
                                    this.Name = "Form1";
                                    this.Text = "Form1";
                                    this.ResumeLayout(false);
                                    this.PerformLayout();

        }

        #endregion

        private _04_exercise.DrawHanged drawHanged;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label lblMistakes;
    }
}

