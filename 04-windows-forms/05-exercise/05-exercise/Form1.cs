using _05_exercise.Properties;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace _05_exercise
{
    public partial class Form1 : Form
    {
        private string title ="Exercise 5";
        private int titleSize = 9;
        private string titleText;
        private int titleCont;
        private string tempTitle;

        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            titleText = "    " + title + "    ";
            this.Text = titleText.Substring(0, titleSize);
            timer.Interval = 200;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Start();
            checkSize();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {

            this.Icon = titleCont % 2 == 0 ? Resources.ico1 : Resources.ico2;

            if (titleCont <= 0)
            {
                titleCont = titleText.Length - 1;
            }
            else
            {
                tempTitle = titleText[titleCont] + this.Text;

                if (tempTitle.Length >= titleSize)
                {
                    tempTitle = tempTitle.Substring(0, titleSize);
                }

                this.Text = tempTitle;
                titleCont--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAndAddToLeft();
            checkSize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            removeElementsBox1();
            checkSize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.Items.Count > 0 && listBoxLeft.SelectedItems.Count > 0)
            {

                for (int i = listBoxLeft.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxRight.Items.Insert(0, listBoxLeft.SelectedItems[i]);
                }

                removeElementsBox1();
                checkSize();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBoxRight.Items.Count > 0 && listBoxRight.SelectedItems.Count>0)
            {
                listBoxLeft.Items.Insert(0, listBoxRight.SelectedItem);
                listBoxRight.Items.Remove(listBoxRight.SelectedItem);
                checkSize();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSize();
        }
        private void removeElementsBox1()
        {
            for (int i = listBoxLeft.Items.Count - 1; i >= 0; i--)
            {
                if (listBoxLeft.SelectedItems.Contains(listBoxLeft.Items[i]))
                {
                    listBoxLeft.Items.RemoveAt(i);
                }
            }
        }
        private void getAndAddToLeft()
        {
            if (textBox1.Text.Trim() != "")
            {
                if (!listBoxLeft.Items.Contains(textBox1.Text))
                {
                    listBoxLeft.Items.Add(textBox1.Text);
                }
            }

        }

        private void checkSize()
        {
            string index = "";

            lblItems.Text = "Items: " + listBoxLeft.Items.Count.ToString();

            for (int i = 0; i < listBoxLeft.SelectedIndices.Count; i++)
            {
                index += "\n"+listBoxLeft.SelectedIndices[i].ToString();
            }

            lblSelectedItems.Text = "Selected Items: " + index;
            toolTip1.SetToolTip(listBoxRight, "Items: " + listBoxRight.Items.Count.ToString());
        }


    }
}