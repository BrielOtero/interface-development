using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_exercise
{
    [DefaultProperty("TextLbl"), DefaultEvent("Load")]
    public partial class LabelTextBox : UserControl
    {
        [Category("The Property Change")]
        [Description("Fired when the Position property change")]
        public event EventHandler PositionChanged;

        [Category("The Property Change")]
        [Description("Fired when the Separation property change")]
        public event EventHandler SeparationChanged;

        [Category("The Property change")]
        [Description("Fired when the Txt property Change")]
        public event EventHandler TxtChanged;

        private ePosition position = ePosition.Left;

        private int separation = 0;

        private char pswChr;

        [Category("Property")]
        [Description("Value of PswChr")]
        public char PswChr
        {
            set
            {
                    pswChr = value;
                    txt.PasswordChar = pswChr;
            }
            get
            {
                return pswChr;
            }
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            relocate();
        }

        [Category("Appearance")]
        [Description("Show if label is on left or right of Textbox")]
        public ePosition Position
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosition), value))
                {
                    position = value;
                    relocate();
                    //OnPositionChanged(EventArgs.Empty);
                    PositionChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }

            get
            {
                return position;
            }
        }

        void relocate()
        {
            switch (position)
            {
                case ePosition.Left:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separation, 0);
                    break;
                case ePosition.Right:
                    txt.Location = new Point(0, 0);
                    lbl.Location = new Point(txt.Width + Separation, 0);
                    break;
            }

            this.Width = lbl.Width+Separation+txt.Width+1;
            this.Height = Math.Max(txt.Height, lbl.Height);
        }

        //private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        //{
        //    relocate();
        //}

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            relocate();
        }


        [Category("Design")]
        [Description("Pixels of separation between Label and Textbox")]
        public int Separation
        {
            set
            {
                if (value >= 0)
                {
                    separation = value;
                    relocate();
                    SeparationChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            get
            {
                return separation;
            }
        }

        [Category("Appearance")]
        [Description("Text associate to Label of Control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                relocate();
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Appearance")]
        [Description("Text associate to Textbox of Control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }



        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TxtChanged?.Invoke(this, EventArgs.Empty);
        }

        //protected virtual void OnPositionChanged(EventArgs e)
        //{
        //    if (PositionChanged!= null)
        //    {
        //        PositionChanged(this, e);
        //    }
        //}

    }

}
