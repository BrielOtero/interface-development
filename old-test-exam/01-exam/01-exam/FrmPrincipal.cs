using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace _01_exam
{
    public partial class FrmPrincipal : Form
    {
        Timer timerAnimacion = new Timer();
        int buttonColorPicker = 1;
        int checkedItems = 0;
        public FrmPrincipal()
        {
            InitializeComponent();

            tsmiJugar.Click += new EventHandler((sender, e) => BtnJugar.PerformClick());
            tsmiReset.Click += new EventHandler((sender, e) => BtnReset.PerformClick());
            tsmiSalir.Click += new EventHandler((sender, e) => BtnSalir.PerformClick());

            BtnJugar.BackColor = Color.Beige;
            BtnReset.BackColor = Color.Beige;
            BtnSalir.BackColor = Color.Beige;

            crearCheckBox();

            timerAnimacion.Tick += new EventHandler(tickTimer);
            timerAnimacion.Interval = 300;
            timerAnimacion.Start();

        }
        private void tickTimer(object sender, EventArgs e)
        {
            BtnJugar.BackColor = Color.Beige;
            BtnReset.BackColor = Color.Beige;
            BtnSalir.BackColor = Color.Beige;

            switch (buttonColorPicker)
            {
                case 1:
                    BtnJugar.BackColor = Color.Yellow;
                    break;
                case 2:
                    BtnReset.BackColor = Color.Yellow;
                    break;
                case 3:
                    BtnSalir.BackColor = Color.Yellow;
                    break;
            }

            if (buttonColorPicker < 3)
            {
                buttonColorPicker++;
            }
            else
            {
                buttonColorPicker = 1;
            }

        }
        private void crearCheckBox()
        {
            int x = 30;
            int y = 30;
            for (int i = 1; i < 50; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = i.ToString();
                checkBox.Checked = false;
                checkBox.Size = new Size(40, 40);
                checkBox.Location = new Point(x, y);
                checkBox.CheckedChanged += checkbox_CheckedChange;
                checkBox.Name = $"chk{i}";
                toolTipPrincipal.SetToolTip(checkBox, "No marcada");
                Controls.Add(checkBox);

                if (i % 9 != 0)
                {
                    x += 50;
                }
                else
                {
                    x = 30;
                    y += 50;
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 50; i++)
            {
                ((CheckBox)Controls[$"chk{i}"]).BackColor = FrmPrincipal.DefaultBackColor;
                ((CheckBox)Controls[$"chk{i}"]).Checked = false;
                toolTipPrincipal.SetToolTip(Controls[$"chk{i}"], "No marcada");

            }
            LblResultados.Text = "Resultados";
            this.checkedItems = 0;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LstNombres.Items.Count > 0)
            {
                if (MessageBox.Show(this, "Se saldrá de la aplicación", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(checkedItems.ToString());
            switch (checkedItems)
            {
                case > 6:
                    MessageBox.Show(this, $"Debes marcar 6, Te has pasado!  has marcado {checkedItems}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case < 6:
                    MessageBox.Show(this, $"Debes marcar 6, Ya casi lo tienes! has marcado {checkedItems}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    jugar();
                    break;
            }

        }

        private void jugar()
        {
            List<int> randomNumbers = new List<int>();

            Random r = new Random();
            int randNumber;
            int aciertos = 0;

            for (int i = 0; i < 6; i++)
            {
                randNumber = r.Next(1, 50);
                randomNumbers.Add(randNumber);
                Trace.WriteLine(randNumber);
                LblResultados.Text += $" {randNumber}";
                CheckBox chk = ((CheckBox)Controls[$"chk{randNumber}"]);
                if (chk.Checked)
                {
                    chk.BackColor = Color.Gold;
                    aciertos++;
                }
            }

            if (aciertos >= 1)
            {
                FrmDatos frmDatos = new FrmDatos();

                switch (frmDatos.ShowDialog())
                {
                    case DialogResult.Cancel:
                        BtnReset.PerformClick();

                        break;
                    case DialogResult.OK:
                        LstNombres.Items.Add(new Record(frmDatos.Nombre, frmDatos.Edad, aciertos));

                        BtnReset.PerformClick();
                        break;
                }
            }
        }

        private void checkbox_CheckedChange(Object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                checkedItems++;
                toolTipPrincipal.SetToolTip((CheckBox)sender, "Marcada");
            }
            else
            {
                checkedItems--;
                toolTipPrincipal.SetToolTip((CheckBox)sender, "No Marcada");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            LstNombres.Items.Clear();
        }
    }
}