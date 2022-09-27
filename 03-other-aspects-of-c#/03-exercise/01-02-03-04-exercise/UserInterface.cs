using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    internal class UserInterface
    {
        private PeopleManager pm = new PeopleManager();
        private string cutString(string value, int chars)
        {

            if (value.Length > chars)
            {

                return value.Substring(0, chars - 3) + "...";
            }

            return value;
        }

        private void paintSubmenu(string[] options, int option, string title)
        {

            Console.Clear();
            Console.WriteLine($"\n{title,-30}\n\n");
            for (int i = 0; i < options.Length; i++)
            {
                if (i == option)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine($"{i}. {options[i],-30}");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

            }
        }

        private void resume()
        {
            Console.WriteLine($"{"Pulse ENTER to continue",20}");
            ConsoleKeyInfo keyPress = Console.ReadKey(intercept: true);

            while (keyPress.Key != ConsoleKey.Enter)
            {
                keyPress = Console.ReadKey(intercept: true);
            }
        }

        private int subMenu(string title, params string[] options)
        {
            bool exit = false;

            int option = 0;
            int select = -1;

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            paintSubmenu(options, option, title);
            Console.WriteLine($"{"Pulse ENTER to select",-30}");

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
                }
                paintSubmenu(options, option, title);
                Console.WriteLine($"{"Pulse ENTER to select",-30}");

            } while (!exit);

            Console.Clear();

            return select;
        }

        public void Start()
        {
            int menu;
            int index;
            string[] typesPerson = { "Employee", "Executive" };
            string[] mainMenu = { "Insert Person", "Delete Person in range", "Show all People", "Show a Person", "Exit" };
            string[] yesNo = { "Yes", "No" };


            Employee e = new Employee("Manolo", "Sanchez", 22, "33144756C", 25000, "614567426");
            Executive ex = new Executive("Paco", "Martinez", 50, "23148944E", "Contabilidad", 3);

            pm.people.Insert(pm.Position(e.Age), e);
            pm.people.Insert(pm.Position(ex.Age), ex);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            do
            {
                menu = subMenu("Choose an option:", mainMenu);
                Console.Clear();

                switch (menu)
                {
                    case 0:

                        index = subMenu("Select one", typesPerson);

                        if (index == 0)
                        {
                            Employee employee = new Employee();
                            employee.InsertValues();

                            pm.people.Insert(pm.Position(employee.Age), employee);

                        }
                        else
                        {
                            Executive executive = new Executive();
                            executive.InsertValues();
                            pm.people.Insert(pm.Position(executive.Age), executive);
                        }

                        resume();
                        break;
                    case 1:

                        if (pm.people.Count >= 2)
                        {
                            string letter;
                            int min;
                            int max;

                            string[] menuPeople;
                            List<string> listMenu = new List<string>();

                            string menuTitle = $"|{"i",-3}|{"Name",-10}|{"Surname",-20}|{"Letter",-10}|";

                            for (int i = 0; i < pm.people.Count; i++)
                            {
                                letter = pm.people[i].GetType() == typeof(Executive) ? "D" : "E";
                                listMenu.Add($"|{i,-3}|{cutString(pm.people[i].Name, 10),-10}|{cutString(pm.people[i].Name, 20),-20}|{letter,-10}");
                            }

                            do
                            {

                            menuPeople= listMenu.ToArray();

                            min = subMenu("Select the minimum value to delete", menuPeople);

                            } while (min >= menuPeople.Length-1);


                            listMenu.RemoveRange(0, min+1);

                            menuPeople = listMenu.ToArray();

                            max = subMenu("Select the maximun value to delete", menuPeople);

                            for (int i = min; i <= max; i++)
                            {
                                letter = pm.people[i].GetType() == typeof(Executive) ? "D" : "E";
                                Console.WriteLine($"{i,3}. Name: {cutString(pm.people[i].Name, 10),10} Surname:{cutString(pm.people[i].Name, 20),20} {letter} {pm.people[i].Age}");
                            }

                            int delete = subMenu("Do you really delete this elements?", yesNo);

                            if (delete == 0)
                            {
                                bool correctDelete = pm.Delete(max, min);

                                if (correctDelete)
                                {
                                    Console.WriteLine("Elements was delete correctly");
                                }
                                else
                                {
                                    Console.WriteLine("Elements wasn't delete");
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("You need almost 2 person to delete");
                        }


                        resume();

                        break;
                    case 2:
                        showAllPeople();

                        break;
                    case 3:

                        break;
                    case 4:
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
            } while (menu != 4);
        }

        private void showAllPeople(bool showResume = true)
        {
            string letter;
            string header = $"|{"i",-3}|{"Name",-10}|{"Surname",-20}|{"Letter",-10}|";
            Console.WriteLine(header);
            Console.WriteLine();

            for (int i = 0; i < pm.people.Count; i++)
            {
                letter = pm.people[i].GetType() == typeof(Executive) ? "D" : "E";
                System.Console.WriteLine($"|{i,-3}|{cutString(pm.people[i].Name, 10),-10}|{cutString(pm.people[i].Name, 20),-20}|{letter,-10}");
            }

            if (showResume)
            {
                resume();
            }
        }

        private int askMaxMin(string sentence, int max, int min = 0)
        {
            int value;
            bool isWorking = true;

            do
            {
                Console.Clear();

                showAllPeople(false);


                if (!isWorking)
                {
                    Console.WriteLine("Insert a valid value");
                }

                Console.WriteLine($"\nInsert the {sentence} index to delete");

                isWorking = Int32.TryParse(Console.ReadLine(), out value);

                if (value < min || value >= max)
                {
                    isWorking = false;
                }


            } while (!isWorking);

            return value;
        }
    }

}
