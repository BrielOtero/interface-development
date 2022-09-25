using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercise
{
    internal class Menu
    {
        string[] students;
        Classroom c;

        public Menu(params string[] students)
        {
            this.students = students;
            c = new Classroom(this.students);
        }

        private void paintSubmenu(string[] options, int option, string title)
        {

            Console.Clear();
            Console.WriteLine(title);
            for (int i = 0; i < options.Length; i++)
            {
                if (i == option)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine($"{i}. {options[i]}");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        private int subMenu(bool isStudent)
        {
            string[] options;
            string title;
            bool exit = false;

            if (isStudent)
            {
                options = students;
                title = "Select one Student";
            }
            else
            {
                options = Enum.GetNames(typeof(Subjects));
                title = "Select one Subject";

            }

            int option = 0;
            int select = -1;

            Console.CursorVisible = false;
            paintSubmenu(options, option, title);
            Console.WriteLine("Pulse ENTER to select");

            do
            {
                ConsoleKeyInfo tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = option < options.Length - 1 ? option + 1 : option;
                        break;
                    case ConsoleKey.UpArrow:
                        option = option > 0 ? option - 1 : option;
                        break;
                    case ConsoleKey.Enter:

                        select = option;
                        exit = true;
                        break;
                    case ConsoleKey.Escape:
                        select = options.Length - 1;
                        break;

                }
                paintSubmenu(options, option, title);
                Console.WriteLine("Pulse ENTER to select");

            } while (!exit);

            Console.Clear();

            return select;
        }

        private string cutString(string value, int chars)
        {

            if (value.Length > chars)
            {

                return value.Substring(0, chars - 3) + "...";
            }

            return value;
        }

        private void changeColor(ref int colorIndex)
        {
            if (colorIndex == 0)
            {
                colorIndex++;
            }

            Console.BackgroundColor = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue(colorIndex);
            Console.ForegroundColor = ConsoleColor.Black;

            if (colorIndex < 15)
            {
                colorIndex++;
            }
            else
            {
                colorIndex = 0;
            }


        }

        public void Start()
        {

            bool isValid = true;
            int colorIndex = 0;
            int menu;
            int index;
            int w = 10;
            string[] subjects = Enum.GetNames(typeof(Subjects));

            do
            {
                changeColor(ref colorIndex);
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine();
                changeColor(ref colorIndex);
                Console.WriteLine("1. Show average of the table ");
                changeColor(ref colorIndex);
                Console.WriteLine("2. Show average of one student ");
                changeColor(ref colorIndex);
                Console.WriteLine("3. Show average of one subject ");
                changeColor(ref colorIndex);
                Console.WriteLine("4. Show notes of one student ");
                changeColor(ref colorIndex);
                Console.WriteLine("5. Show notes of one subject ");
                changeColor(ref colorIndex);
                Console.WriteLine("6. Show Max-Min note of one student ");
                changeColor(ref colorIndex);
                Console.WriteLine("7. Show all table ");
                changeColor(ref colorIndex);
                Console.WriteLine("8. Exit ");
                changeColor(ref colorIndex);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                isValid = Int32.TryParse(Console.ReadLine(), out menu);
                Console.WriteLine();

                if (!isValid)
                {
                    menu = -1;
                }
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        showAverageAllTable();

                        break;
                    case 2:
                        index = subMenu(true);
                        showAverageStudent(index);

                        break;
                    case 3:
                        index = subMenu(false);
                        showAverageSubject(index);

                        break;
                    case 4:
                        index = subMenu(true);
                        showNotesStudent(index, w, subjects);

                        break;
                    case 5:
                        index = subMenu(false);
                        showNotesSubject(index, w);

                        break;
                    case 6:

                        index = subMenu(true);

                        showMaxMinStudent(index);

                        break;
                    case 7:
                        showAllTable(w, subjects);

                        break;
                    case 8:
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("+----------------+");
                        Console.WriteLine("| Invalid option |");
                        Console.WriteLine("+----------------+");
                        Console.WriteLine();
                        Console.ResetColor();
                        break;
                }
            } while (menu != 8);
        }

        private void showMaxMinStudent(int index)
        {
            c.GetMaxMinStudent(index, out int min, out int max);

            Console.WriteLine($"{students[index]} has a minimun of {min} and maximun of {max}");
        }

        private void showAverageAllTable()
        {
            Console.WriteLine($"The average of the table is {c.GetAverageTable():F2}");
        }

        private void showAverageStudent(int index)
        {
            Console.WriteLine($"{students[index]} has an average of {c.GetAverageStudent(index):F2}");
        }

        private void showAverageSubject(int index)
        {
            Console.WriteLine($"{(Subjects)index} has an average of {c.GetAverageSubject(index):F2}");
        }

        private void showNotesStudent(int index, int w, string[] subjects)
        {
            Console.Write($"{students[index]} has this notes\n\n|");

            foreach (string subject in subjects)
            {
                Console.Write($"{cutString(subject, w),-10}|");
            }
            Console.Write("\n|");

            for (int i = 0; i < c.Notes.GetLength(0); i++)
            {
                Console.Write($"{c[i, index],-10}|");
            }
        }

        private void showNotesSubject(int index, int w)
        {
            Console.Write($"{(Subjects)index} has this notes\n\n|");

            foreach (string student in students)
            {
                Console.Write($"{cutString(student, w),-10}|");
            }

            Console.Write("\n|");

            for (int i = 0; i < c.Notes.GetLength(1); i++)
            {
                Console.Write($"{c[index, i],-10}|");
            }
        }

        private void showAllTable(int w, string[] subjects)
        {
            Console.Write("|          |");
            foreach (string subject in subjects)
            {
                Console.Write($"{cutString(subject, w),-10}|");
            }
            Console.Write("\n");

            for (int i = 0; i < c.Notes.GetLength(1); i++)
            {
                Console.Write($"|{cutString(students[i], w),-10}|");

                for (int j = 0; j < c.Notes.GetLength(0); j++)
                {
                    Console.Write($"{c[j, i],-10}|");
                }
                Console.Write("\n");
            }
        }
    }

}
