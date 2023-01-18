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
            this.barChart1 = new _06_exercise.BarChart();
            this.SuspendLayout();
            // 
            // barChart1
            // 
            this.barChart1.BarCharMode = _06_exercise.eBarChartMode.MANUAL;
            this.barChart1.BarChartForecolor = System.Drawing.Color.Black;
            this.barChart1.BarChartMaxY = 0D;
            this.barChart1.BarCharType = _06_exercise.eBarChartType.COLUMNS;
            this.barChart1.Location = new System.Drawing.Point(69, 62);
            this.barChart1.Name = "barChart1";
            this.barChart1.Size = new System.Drawing.Size(491, 238);
            this.barChart1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private _06_exercise.BarChart barChart1;
    }
}

