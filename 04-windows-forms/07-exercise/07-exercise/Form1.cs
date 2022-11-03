using _02_exercise;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _07_exercise
{
    public partial class Form1 : Form
    {
        private Classroom c;
        private Label lbl;
        private string students;
        private int WIDTH_TEXT = 20;
        private Color DEFAULT_BACKGROUND;
        private string[] subjects;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Classroom";
            try
            {
                students = File.ReadAllText(Environment.GetEnvironmentVariable("userprofile") + Path.DirectorySeparatorChar.ToString() + "students.csv");
            }
            catch (FileNotFoundException)
            {
                Trace.TraceError("FileNotFoundException");
                error();
                return;
            }
            catch (Exception)
            {
                Trace.TraceError("Exception");
                error();
                return;
            }

            c = new Classroom(students);
            subjects = Enum.GetNames(typeof(Subjects));
            DEFAULT_BACKGROUND = Form1.DefaultBackColor;

            cbxStudents.Items.AddRange(c.students);
            cbxSubjects.Items.AddRange(subjects);

            lbl1_update();


            int x;
            int y;

            x = 109;
            y = 99;

            for (int i = 0; i < subjects.Length; i++)
            {
                createLabel(cutString(subjects[i], 10), new Point(x, y));
                x += 99;
            }

            x = 10;
            y += 24;


            for (int i = 0; i < c.Notes.GetLength(1); i++)
            {
                createLabel(cutString(c.students[i], WIDTH_TEXT), new Point(x, y));

                for (int j = 0; j < c.Notes.GetLength(0); j++)
                {
                    x += 99;
                    createLabel(cutString(c[j, i].ToString(), WIDTH_TEXT), new Point(x, y), $"{c.students[i]}\r{subjects[j]}");
                }
                x = 10;
                y += 24;
            }
        }

        private void createLabel(String text, Point p, string tipText = "")
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
            lblTableInfo.Text = $"Table Average: {c.GetAverageTable()}";

            int indexStu = cbxStudents.SelectedIndex;
            int indexSub = cbxSubjects.SelectedIndex;

            if (indexStu != -1)
            {
                c.GetMaxMinStudent(indexStu, out int min, out int max);
                lblTableInfo.Text += $"\rAverage for {cbxStudents.SelectedItem}: {c.GetAverageStudent(cbxStudents.SelectedIndex)}\r{cbxStudents.SelectedItem} has Min: {min} Max: {max}";
            }

            if (indexSub != -1)
            {
                lblTableInfo.Text += $"\rAverage for {cbxSubjects.SelectedItem}: {c.GetAverageSubject(cbxSubjects.SelectedIndex)}";
            }
        }

        private string cutString(string value, int chars)
        {

            if (value.Length > chars)
            {

                return value.Substring(0, chars - 3) + "...";
            }

            return value;
        }

        private void error()
        {
            if (MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl1_update();
        }
    }
}
