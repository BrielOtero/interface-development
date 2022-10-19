using _05_exercise.Properties;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace _05_exercise
{
    public partial class Form1 : Form
    {
        private string title = "          Exercise 5";
        private int titleCont;
        private string tempTitle;

        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
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
                titleCont = title.Length - 1;
            }
            else
            {
                tempTitle = title[titleCont] + this.Text;

                this.Text = titleCont < 10 ? tempTitle.Substring(0, 9) : tempTitle;

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



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                getAndAddToLeft();
            }
            checkSize();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Insert(0, listBox1.SelectedItems[i]);
            }

            removeElementsBox1();
            checkSize();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            checkSize();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSize();
        }
        private void removeElementsBox1()
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.SelectedItems.Contains(listBox1.Items[i]))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
        }
        private void getAndAddToLeft()
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void checkSize()
        {
            label1.Text = "Items: " + listBox1.Items.Count.ToString();
            label2.Text = "Selected Items: " + listBox1.SelectedItems.Count.ToString();
            toolTip1.SetToolTip(listBox2, "Items: " + listBox2.Items.Count.ToString());
        }


    }
}