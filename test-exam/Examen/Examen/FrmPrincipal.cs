namespace Examen
{
    public partial class FrmPrincipal : Form
    {
        private int _checkBoxChecked;
        private List<int> _randomNumbers = new List<int>();
        private int _aciertos = 0;
        public FrmPrincipal()
        {
            InitializeComponent();
            InitializeTable();
            btnSalir.Click += new EventHandler((sender, e) => this.Close());
            jugarToolStripMenuItem.Click += new EventHandler((sender, e) => btnJugar.PerformClick());
            resetToolStripMenuItem.Click += new EventHandler((sender, e) => btnReset.PerformClick());
            salirToolStripMenuItem.Click += new EventHandler((sender, e) => btnSalir.PerformClick());
            _checkBoxChecked = 0;
        }

        private CheckBox CreateCheckBox(string text, Size size, Point location, string tooltipMessage, int tabIndex)
        {
            CheckBox c = new CheckBox();
            c.Name = $"ckb{text}";
            c.Text = text;
            c.Size = size;
            c.Location = location;
            toolTip1.SetToolTip(c, tooltipMessage);
            c.TabIndex = tabIndex;
            c.CheckedChanged += new EventHandler(CheckedChange);
            return c;
        }

        private void InitializeTable()
        {
            int x = 30;
            int y = 30;
            for (int i = 0; i < 49; i++)
            {
                this.Controls.Add(CreateCheckBox($"{i + 1}", new Size(40, 40), new Point(x, y), "No marcado", i));
                if ((i + 1) % 9 == 0)
                {
                    x = 30;
                    y += 40;
                }
                else
                {
                    x += 40;
                }
            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            bool next = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    if (next)
                    {
                        this.Controls[i].BackColor = Color.Yellow;
                        break;
                    }
                    if (this.Controls[i].BackColor == Color.Yellow)
                    {
                        this.Controls[i].BackColor = Color.Beige;
                        next = true;
                    }
                }
            }
            if (!next)
            {
                this.Controls["btnJugar"].BackColor = Color.Yellow;
            }
        }

        private void ResetClick(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                    ((CheckBox)control).BackColor = CheckBox.DefaultBackColor;
                }
            }
            lblResultados.Text = "Resultados";
        }

        private void JugarClick(object sender, EventArgs e)
        {
            _randomNumbers.Clear();
            if (_checkBoxChecked == 6)
            {
                for (int i = 0; i < _checkBoxChecked; i++)
                {
                    _randomNumbers.Add(new Random().Next(1, 50));
                }
                UpdateResultados();
                FrmDatos f = new FrmDatos();
                DialogResult result = f.ShowDialog();
                if (result == DialogResult.Cancel || result == DialogResult.OK)
                {
                    btnReset.PerformClick();
                }
                if (result == DialogResult.OK)
                {
                    lstNombres.Items.Add(new Record(f.Nombre, f.Edad, _aciertos));
                }
            }
            else
            {
                MessageBox.Show("No se puede seleccionar mas de 6 casillas", "", MessageBoxButtons.OK);
            }
        }

        private void EliminarClick(object sender, EventArgs e)
        {
            if (lstNombres.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstNombres.SelectedIndices.Count; i++)
                {
                    lstNombres.Items.RemoveAt(lstNombres.SelectedIndices[i]);
                }
            }
        }

        private void CloseEvent(object sender, FormClosingEventArgs e)
        {
            if (lstNombres.Items.Count > 0)
            {
                if (MessageBox.Show("Se saldra de la aplicacion", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void CheckedChange(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                _checkBoxChecked++;
                toolTip1.SetToolTip((CheckBox)sender, "Marcado");
            }
            else
            {
                _checkBoxChecked--;

                toolTip1.SetToolTip((CheckBox)sender, "No marcado");
            }

        }

        private void UpdateResultados()
        {
            lblResultados.ResetText();
            _aciertos = 0;
            for (int i = 0; i < _randomNumbers.Count; i++)
            {
                lblResultados.Text += $"\nResultado {i}: {_randomNumbers[i]}";
                if (((CheckBox)this.Controls[$"ckb{_randomNumbers[i]}"]).Checked)
                {
                    this.Controls[$"ckb{_randomNumbers[i]}"].BackColor = Color.Gold;
                    _aciertos++;
                }
            }
        }
    }
}