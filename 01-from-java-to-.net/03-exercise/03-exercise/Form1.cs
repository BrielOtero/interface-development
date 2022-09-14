#define WIN
namespace _03_exercise
#nullable disable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            TextBox[] txtBox = { textBox1, textBox2, textBox3 };
            int[] numbers = new int[3];

            for (int i = 0; i < 3; i++)
            {
                numbers[i] = r.Next(1, 8);
                txtBox[i].Text = String.Format("{0}", numbers[i]);
            }

            label1.Text = String.Format("{0}", Convert.ToInt32(label1.Text) - 2);



            if (numbers[0] == numbers[1] && numbers[1] == numbers[2])
            {
                label1.Text = String.Format("{0}", Convert.ToInt32(label1.Text) + 20);
                label2.Text = "+20";


            }
            else if (numbers[0] == numbers[1] || numbers[0] == numbers[2] || numbers[1] == numbers[2])
            {
#if WIN
                label1.Text = String.Format("{0}", Convert.ToInt32(label1.Text) + 5);
                label2.Text = "+5";
#else

                label1.Text = String.Format("{0}", Convert.ToInt32(label1.Text) - 5);
                label2.Text = "-5";
#endif

            }
            else
            {
                label2.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", Convert.ToInt32(label1.Text) + 10);
            label2.Text = "+10";
        }
    }
}