using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_exam
{
    public partial class FrmDatos : Form
    {
        public string Nombre;
        public int Edad;
        public FrmDatos()
        {
            InitializeComponent();

            for (int i = 18; i <= 100; i++)
            {
                CboEdad.Items.Add(i);
            }
            CboEdad.SelectedIndex= 0;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Blue;
            Cursor.Current = Cursors.Hand;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            Cursor.Current = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Nombre=TxtNombre.Text;
            Edad = (int)CboEdad.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
