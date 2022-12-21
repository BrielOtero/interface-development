using _01_exercise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labeTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Text = "Letra: " + e.KeyChar;
        }

        private void btnChangePosition_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void labelTextBox1_PositionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Position.ToString();
        }

        private void btnChangePosition_Click(object sender, EventArgs e)
        {
            labelTextBox1.Position = labelTextBox1.Position == ePosition.Left ? ePosition.Right : ePosition.Left;

        }

        private void labelTextBox1_SeparationChanged(object sender, EventArgs e)
        {
            lblSeparation.Text = labelTextBox1.Separation.ToString();
        }

        private void btnSeparationIncrease_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separation = labelTextBox1.Separation + 1;
        }

        private void btnSeparationDecrease_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separation > 0)
            {
                labelTextBox1.Separation = labelTextBox1.Separation - 1;
            }
            else
            {
                MessageBox.Show(this, "Separation can't be negative");
            }
        }

        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            lblInfo1.BackColor = lblInfo1.BackColor == Form.DefaultBackColor ? Color.Red : Form.DefaultBackColor;
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            lblInfo2.BackColor = lblInfo2.BackColor == Form.DefaultBackColor ? Color.Orange : Form.DefaultBackColor;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                labelTextBox1.PswChr = char.Parse(txtPass.Text);
            }
            else
            {
                MessageBox.Show(this, "Not valid value");
            }
        }
    }
}
