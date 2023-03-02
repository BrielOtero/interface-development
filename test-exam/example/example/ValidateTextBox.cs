using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example {
    public partial class ValidateTextBox : UserControl {
        public enum eTipo {
            NUMERICO, TEXTUAL
        }

        public ValidateTextBox() {
            InitializeComponent();
            Relocate();
        }

        [Category("La propiedad cambia")]
        [Description("Se lanza cuando la propiedad texto cambia")]
        public string Texto {
            set { txtBox.Text = value; }
            get { return txtBox.Text; }
        }

        [Category("La propiedad cambia")]
        [Description("Se lanza cuando la propiedad multiline cambia")]
        public bool Multilinia {
            set { txtBox.Multiline = value; }
            get { return txtBox.Multiline; }
        }

        public eTipo Tipo {
            set;
            get;
        }


        private void ValidateTextBox_SizeChanged(object sender, EventArgs e) {
            Relocate();
        }

        private void Relocate() {
            this.Height = txtBox.Height + 20;
            txtBox.Width = this.Width - 20;
        }
    }
}
