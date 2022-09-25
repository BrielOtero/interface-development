using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    internal class UserInterface
    {

        private void paintSubmenu(string[] options, int option, string title)
        {

            Console.Clear();
            Console.WriteLine($"\n{ title}\n\n");
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

        private int subMenu(string title, params string[] options)
        {
            bool exit = false;

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
            string[] typesPerson = { "Employee", "Executive" };
            PeopleManager pm = new PeopleManager();
            do
            {
                changeColor(ref colorIndex);
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                Console.WriteLine();
                changeColor(ref colorIndex);
                Console.WriteLine("1. Insert Person");
                changeColor(ref colorIndex);
                Console.WriteLine("2. Delete Person");
                changeColor(ref colorIndex);
                Console.WriteLine("3. Show all People");
                changeColor(ref colorIndex);
                Console.WriteLine("4. Show a Person");
                changeColor(ref colorIndex);
                Console.WriteLine("5. Exit");
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

                      index=  subMenu("Select one", typesPerson);
                        if (index == 0)
                        {
                            Employee employee = new Employee();

                            employee.InsertValues();


                        }
                        else
                        {
                            Executive executive = new Executive();
                            executive.InsertValues();
                        }

                        //pm.people.Add
                        

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
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
            } while (menu != 5);
        }
    }
    
}
