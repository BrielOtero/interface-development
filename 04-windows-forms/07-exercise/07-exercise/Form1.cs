using _02_exercise;

namespace _07_exercise
{
    public partial class Form1 : Form
    {
        private Classroom c;
        private Label lbl;
        private string[] students;
        private int WIDTH_TEXT = 20;
        private Color DEFAULT_BACKGROUND;
        private string[] subjects;

        public Form1()
        {
            InitializeComponent();

            students = new string[] { "Paco", "Pepe", "Manolo", "Lola" };
            c = new Classroom(students);
            subjects = Enum.GetNames(typeof(Subjects));
            DEFAULT_BACKGROUND = Form1.DefaultBackColor;


            int x;
            int y;

            x = 109;
            y = 99;

            for (int i = 0; i < subjects.Length; i++)
            {
                createButton(cutString(subjects[i], 10), new Point(x, y));

                x += 99;
            }

            x = 10;
            y += 24;


            for (int i = 0; i < c.Notes.GetLength(1); i++)
            {
                createButton(cutString(students[i], WIDTH_TEXT), new Point(x, y));

                for (int j = 0; j < c.Notes.GetLength(0); j++)
                {
                    x += 99;
                    createButton(cutString(c[j, i].ToString(), WIDTH_TEXT), new Point(x, y), $"{students[i]}\r{subjects[j]}");
                }
                x = 10;
                y += 24;

            }


        }

        private void createButton(String text, Point p, string tipText = "")
        {
            lbl = new Label();
            lbl.Text = text;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            if (tipText != "")
            {
                toolTip1.SetToolTip(lbl, tipText);
                lbl.MouseEnter += new EventHandler(this.lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(this.lbl_MouseLeave);
            }
            lbl.Size = new Size(100, 25);
            lbl.Location = new Point(p.X, p.Y);

            Controls.Add(lbl);
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Yellow;
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = DEFAULT_BACKGROUND;
        }

        private void lbl1_update()
        {
            label1.Text = "Average:{}\rAverage for {}:{}\rMax for{}:{}\rMin for{}:{}\rAverage for {}:{}";
        }

        private string cutString(string value, int chars)
        {

            if (value.Length > chars)
            {

                return value.Substring(0, chars - 3) + "...";
            }

            return value;
        }
    }
}
