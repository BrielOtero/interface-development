using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace _05_exercise
{
    public partial class Form1 : Form
    {
        private string title = "     Exercise 5";
        private string refreshTitle = "     ";
        int titleCont = 0;

        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            if (titleCont >= title.Length)
            {
                titleCont = 0;
            }

            refreshTitle = refreshTitle + title.ElementAt(titleCont);

            refreshTitle = refreshTitle.Substring(1, refreshTitle.Length - 1);

            this.Text = refreshTitle;

            titleCont++;
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
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
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
        }


    }
}