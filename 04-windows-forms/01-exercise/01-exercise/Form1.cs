namespace _01_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text="Mouse Tester";   
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x= e.Location.X;
            int y= e.Location.Y;

            if (sender is Button)
            {
                x += ((Button)sender).Location.X;
                y += ((Button)sender).Location.Y;
            }
            
            this.Text = $"X:{x} | Y:{y}";
        }

    }
}