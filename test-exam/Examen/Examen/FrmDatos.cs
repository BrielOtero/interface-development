using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmDatos : Form
    {
        public string Nombre;
        public int Edad;
        public FrmDatos()
        {
            InitializeComponent();
            InitializeComboBox();
            btnAceptar.MouseEnter += new EventHandler((sender, e) => ((Button)sender).BackColor = Color.Blue);
            btnAceptar.MouseEnter += new EventHandler((sender, e) => this.Cursor = Cursors.Hand);
            btnAceptar.MouseLeave += new EventHandler((sender, e) => ((Button)sender).BackColor = Button.DefaultBackColor);
            btnAceptar.MouseLeave += new EventHandler((sender, e) => this.Cursor = Cursors.Default);
            btnAceptar.Click += new EventHandler((sender, e) => this.DialogResult = DialogResult.OK);
            btnCancelar.MouseEnter += new EventHandler((sender, e) => ((Button)sender).BackColor = Color.Blue);
            btnCancelar.MouseEnter += new EventHandler((sender, e) => this.Cursor = Cursors.Hand);
            btnCancelar.MouseLeave += new EventHandler((sender, e) => ((Button)sender).BackColor = Button.DefaultBackColor);
            btnCancelar.MouseLeave += new EventHandler((sender, e) => this.Cursor = Cursors.Default);
            btnCancelar.Click += new EventHandler((sender, e) => this.DialogResult = DialogResult.Cancel);
            this.FormClosing += new FormClosingEventHandler(SaveData);
        }

        private void InitializeComboBox()
        {
            for (int i = 18; i <= 100; i++)
            {
                cboEdad.Items.Add(i);
            }
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (txtnombre.Text.Length > 0)
                {
                    this.Nombre = txtnombre.Text;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Se necesita un nombre", "", MessageBoxButtons.OK);
                }
                if (cboEdad.SelectedItem != null)
                {
                    this.Edad = (int)cboEdad.SelectedItem;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Se tiene que seleccionar una edad", "", MessageBoxButtons.OK);
                }
            }
        }
    }
}
