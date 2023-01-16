using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace TestWarningLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbChangeMark.Items.Add(eMark.Nothing);
            cbChangeMark.Items.Add(eMark.Circle);
            cbChangeMark.Items.Add(eMark.Cross);
            cbChangeMark.Items.Add(eMark.Image);
            cbChangeMark.SelectedIndex = 0;

        }

        private void btnChangeGradient_Click(object sender, EventArgs e)
        {
            lblWarning.HasGradient = !lblWarning.HasGradient;

        }

        private void cbChangeMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblWarning.Mark = (eMark)cbChangeMark.SelectedItem;
        }

        private void lblWarning_ClickOnMark(object sender, EventArgs e)
        {
            MessageBox.Show(this, "You have clicked on the mark", "Click on mark", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
