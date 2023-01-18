using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _05_Exercise
{
    public partial class ValidateTextBox : UserControl
    {
        private eType type;
        private bool isValid = false;

        public ValidateTextBox()
        {
            InitializeComponent();
            asignSize();
        }

        private void ValidateTextBox_SizeChanged(object sender, EventArgs e)
        {
            asignSize();
        }

        private void asignSize()
        {
            this.Height = txtText.Height + 20;
            txtText.Width = this.Width - 20;
        }


        [Category("Property")]
        [Description("Value of " + nameof(Text))]
        public string Text
        {
            set { txtText.Text = value; }
            get { return txtText.Text; }
        }

        [Category("Property")]
        [Description("Value of " + nameof(Multiline))]
        public bool Multiline
        {
            set { txtText.Multiline = value; }
            get { return txtText.Multiline; }
        }


        [Category("The Property change")]
        [Description("Fired when text property change")]
        public event EventHandler ValidateTextChange;


        [Category("Property")]
        [Description("Value of " + nameof(Type))]
        public eType Type
        {
            set
            {
                type = value;
                checkText();
            }
            get { return type; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Color penColor = isValid ? Color.Green : Color.Red;
            int thickness = 20;
            Pen pen = new Pen(penColor, thickness);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawRectangle(pen, 5, 5, this.Width - 5, this.Height - 5);
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            ValidateTextChange?.Invoke(this, e);    
            checkText();
        }

        private void checkText()
        {
            string text = txtText.Text;
            text = text.Replace(Environment.NewLine, "");

            switch (Type)
            {
                case eType.NUMERIC:
                    text = text.Trim();
                    isValid = text.All(x => Char.IsNumber(x));
                    break;

                case eType.TEXTUAL:
                    isValid = text.All(x => Char.IsLetter(x) || x == ' ');
                    break;
            }
            this.Refresh();
        }
    }
}
