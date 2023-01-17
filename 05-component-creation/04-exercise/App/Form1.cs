using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.Text = "TEST";
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            drawHanged.Mistakes--;
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            drawHanged.Mistakes++;
        }

        private void drawHanged_MistakesChanged(object sender, EventArgs e)
        {
            lblMistakes.BackColor = lblMistakes.BackColor == Form.DefaultBackColor ? Color.Red : Form.DefaultBackColor;
        }

        private void drawHanged_Hanged(object sender, EventArgs e)
        {
            MessageBox.Show(this, "You Lose", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
