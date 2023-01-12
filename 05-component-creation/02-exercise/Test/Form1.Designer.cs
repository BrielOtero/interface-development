namespace Test
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
            this.btnChangePosition = new System.Windows.Forms.Button();
            this.btnSeparationIncrease = new System.Windows.Forms.Button();
            this.btnSeparationDecrease = new System.Windows.Forms.Button();
            this.lblSeparation = new System.Windows.Forms.Label();
            this.lblSeparationInfo = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.labelTextBox1 = new _01_exercise.LabelTextBox();
            this.SuspendLayout();
            // 
            // btnChangePosition
            // 
            this.btnChangePosition.Location = new System.Drawing.Point(146, 51);
            this.btnChangePosition.Name = "btnChangePosition";
            this.btnChangePosition.Size = new System.Drawing.Size(104, 23);
            this.btnChangePosition.TabIndex = 1;
            this.btnChangePosition.Text = "Change Position";
            this.btnChangePosition.UseVisualStyleBackColor = true;
            this.btnChangePosition.Click += new System.EventHandler(this.btnChangePosition_Click);
            // 
            // btnSeparationIncrease
            // 
            this.btnSeparationIncrease.Location = new System.Drawing.Point(66, 92);
            this.btnSeparationIncrease.Name = "btnSeparationIncrease";
            this.btnSeparationIncrease.Size = new System.Drawing.Size(26, 23);
            this.btnSeparationIncrease.TabIndex = 2;
            this.btnSeparationIncrease.Text = "+";
            this.btnSeparationIncrease.UseVisualStyleBackColor = true;
            this.btnSeparationIncrease.Click += new System.EventHandler(this.btnSeparationIncrease_Click);
            // 
            // btnSeparationDecrease
            // 
            this.btnSeparationDecrease.Location = new System.Drawing.Point(15, 92);
            this.btnSeparationDecrease.Name = "btnSeparationDecrease";
            this.btnSeparationDecrease.Size = new System.Drawing.Size(26, 23);
            this.btnSeparationDecrease.TabIndex = 3;
            this.btnSeparationDecrease.Text = "-";
            this.btnSeparationDecrease.UseVisualStyleBackColor = true;
            this.btnSeparationDecrease.Click += new System.EventHandler(this.btnSeparationDecrease_Click);
            // 
            // lblSeparation
            // 
            this.lblSeparation.AutoSize = true;
            this.lblSeparation.Location = new System.Drawing.Point(47, 97);
            this.lblSeparation.Name = "lblSeparation";
            this.lblSeparation.Size = new System.Drawing.Size(13, 13);
            this.lblSeparation.TabIndex = 4;
            this.lblSeparation.Text = "0";
            // 
            // lblSeparationInfo
            // 
            this.lblSeparationInfo.AutoSize = true;
            this.lblSeparationInfo.Location = new System.Drawing.Point(12, 56);
            this.lblSeparationInfo.Name = "lblSeparationInfo";
            this.lblSeparationInfo.Size = new System.Drawing.Size(98, 13);
            this.lblSeparationInfo.TabIndex = 5;
            this.lblSeparationInfo.Text = "Change Separation";
            // 
            // lblInfo1
            // 
            this.lblInfo1.Location = new System.Drawing.Point(365, 12);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(229, 20);
            this.lblInfo1.TabIndex = 6;
            this.lblInfo1.Text = "KeyUp: Alter between --> default and  red";
            // 
            // lblInfo2
            // 
            this.lblInfo2.Location = new System.Drawing.Point(365, 49);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(254, 20);
            this.lblInfo2.TabIndex = 7;
            this.lblInfo2.Text = "TxtChanged: Alter between --> default and orange";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(71, 139);
            this.txtPass.MaxLength = 1;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(39, 20);
            this.txtPass.TabIndex = 8;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 142);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "Password";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(116, 137);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(116, 23);
            this.btnChangePass.TabIndex = 10;
            this.btnChangePass.Text = "Change Password Char";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(12, 12);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Position = _01_exercise.ePosition.Left;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separation = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(173, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PositionChanged += new System.EventHandler(this.labelTextBox1_PositionChanged);
            this.labelTextBox1.SeparationChanged += new System.EventHandler(this.labelTextBox1_SeparationChanged);
            this.labelTextBox1.TxtChanged += new System.EventHandler(this.labelTextBox1_TxtChanged);
            this.labelTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labeTextBox1_KeyPress);
            this.labelTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.labelTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblSeparationInfo);
            this.Controls.Add(this.lblSeparation);
            this.Controls.Add(this.btnSeparationDecrease);
            this.Controls.Add(this.btnSeparationIncrease);
            this.Controls.Add(this.btnChangePosition);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _01_exercise.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button btnChangePosition;
        private System.Windows.Forms.Button btnSeparationIncrease;
        private System.Windows.Forms.Button btnSeparationDecrease;
        private System.Windows.Forms.Label lblSeparation;
        private System.Windows.Forms.Label lblSeparationInfo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnChangePass;
    }
}

