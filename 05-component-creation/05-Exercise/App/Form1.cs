using _05_Exercise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Exercise 5";
        }

        private void chkMultiline_CheckedChanged(object sender, EventArgs e)
        {
            validateTextBox.Multiline = ((CheckBox)sender).Checked;
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "SET TEXTUAL")
            {
                ((Button)sender).Text = "SET NUMERIC";
                validateTextBox.Type = eType.TEXTUAL;
            }
            else
            {
                ((Button)sender).Text = "SET TEXTUAL";
                validateTextBox.Type = eType.NUMERIC;
            }
        }

        private void validateTextBox_ValidateTextChange(object sender, EventArgs e)
        {
            btnType.BackColor = btnType.BackColor == Form.DefaultBackColor ? Color.Green : Form.DefaultBackColor;
        }
    }
}
