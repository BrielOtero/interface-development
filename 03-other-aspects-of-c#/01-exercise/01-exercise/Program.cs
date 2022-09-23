using System.Collections;
using System.Net;

namespace _01_exercise
{
    internal class Program
    {
        private static void askValues(Hashtable computers,out string ip, out int ram)
        {
            bool correct = true;
            ip = "";
            IPAddress ipAdress;

            do
            {
                if (!correct)
                {
                    Console.WriteLine("\nPlease insert a valid ip\n");
                }

                correct = true;

                Console.WriteLine("Insert the IP");
                ip = Console.ReadLine();

                correct = IPAddress.TryParse(ip, out ipAdress);

                if (computers.Contains(ip))
                {
                    correct = false;
                }

            } while (!correct);


            do
            {

                if (!correct)
                {
                    Console.WriteLine("\nPlease insert a valid ram size\n");
                }

                correct = false;


                Console.WriteLine("Insert the ram size in GB");
                correct = Int32.TryParse(Console.ReadLine(), out ram);

                if (ram < 0)
                {
                    correct = false;
                }


            } while (!correct);

        }


        static void Main(string[] args)
        {
            Hashtable computers = new Hashtable();
            bool correct = true;

            int menu;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");
                Console.WriteLine();
                Console.WriteLine("1. Insert value");
                Console.WriteLine("2. Delete value");
                Console.WriteLine("3. Show all values");
                Console.WriteLine("4. Show one value");
                Console.WriteLine("5. Exit");
                correct= Int32.TryParse(Console.ReadLine(),out menu);
                Console.WriteLine();

                if (!correct)
                {
                    menu = 6;
                }


                switch (menu)
                {
                    case 1:
                        addValue(computers);

                        break;
                    case 2:
                        if (computers.Count == 0)
                        {
                            Console.WriteLine("No values");
                        }
                        else
                        {

                        deleteValue(computers);
                        }

                        break;
                    case 3:
                        if (computers.Count == 0)
                        {
                            Console.WriteLine("No values");
                        }
                        else
                        {

                        showAllValues(computers);
                        }

                        break;
                    case 4:
                        if (computers.Count == 0)
                        {
                            Console.WriteLine("No values");
                        }
                        else
                        {

                        showValue(computers);
                        }

                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("+----------------+");
                        Console.WriteLine("| Invalid option |");
                        Console.WriteLine("+----------------+");
                        Console.WriteLine();
                        break;
                }
            } while (menu != 5);

        }



        private static string askForIndex(Hashtable computers, string sentence)
        {
            Console.WriteLine($"Select the index for {sentence}: ");
            bool correct = true;
            string id = "";

            do
            {
                if (!correct)
                {
                    Console.WriteLine("Please insert a valid value");
                }

                correct = true;
                id = Console.ReadLine();

                if (!computers.ContainsKey(id))
                {
                    correct = false;
                }

            } while (!correct);

            return id;
        }

        private static void addValue(Hashtable computers)
        {
            askValues(computers,out string ip, out int ram);

            computers.Add(ip, ram);
        }

        private static void deleteValue(Hashtable computers)
        {
            showAllValues(computers);

            computers.Remove(askForIndex(computers, "Remove"));
        }

        private static void showValue(Hashtable computers)
        {
            Console.WriteLine(computers[askForIndex(computers, "Show")]);
        }

        private static void showAllValues(Hashtable computers)
        {
            foreach (DictionaryEntry de in computers)
            {
                Console.WriteLine($"ID {de.Key} {de.Value}");
            }
        }
    }
}