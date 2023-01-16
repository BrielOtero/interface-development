using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_exercise
{
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        [Category("Action")]
        [Description("Occurs when play is clicked")]
        public event EventHandler PlayClick;

        [Category("The Property Change")]
        [Description("Fired when " + nameof(Seconds) + " property change")]
        public event EventHandler OverflowTime;

        [Category("Property")]
        [Description("Value of minutes to show on " + nameof(lblTime))]
        private int minutes = 0;

        [Category("Property")]
        [Description("Value of seconds to show on " + nameof(lblTime))]
        private int seconds = 0;

        [Category("Property")]
        [Description("Value of seconds to show on " + nameof(lblTime))]
        private bool isPlay = false;

        public bool IsPlay
        {
            set { isPlay = value; }
            get { return isPlay; }
        }

        public int Minutes
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    minutes = value > 59 ? 0 : value;
                }
                updateLblTime();
            }
            get { return minutes; }
        }

        public int Seconds
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else if (value > 59)
                {
                    seconds = value % 60;
                    OverflowTime?.Invoke(value, EventArgs.Empty);
                }
                else
                {
                    seconds = value;
                }
                updateLblTime();
            }
            get { return seconds; }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (btnPlayPause.Text == "Play")
            {
                btnPlayPause.Text = "Pause";
                IsPlay = true;
            }
            else
            {
                btnPlayPause.Text = "Play";
                IsPlay = false;
            }

            PlayClick?.Invoke(this, EventArgs.Empty);
        }

        private void updateLblTime()
        {
            lblTime.Text = $"{minutes,2:d2}:{seconds,02:d2}";
        }

    }
}
