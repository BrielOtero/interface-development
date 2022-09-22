using System.Collections;
using System.Net;

namespace _01_exercise
{
    internal class Program
    {
        private static void askValues(out string ip, out int ram)
        {
            bool error = false;
            ip = "";
            ram = 0;
            IPAddress ipAdress;

            do
            {
                if (error)
                {
                    Console.WriteLine("\nPlease insert a valid ip\n");
                }

                error = false;

                Console.WriteLine("Insert the IP");
                ip = Console.ReadLine();

                error = IPAddress.TryParse(ip, out ipAdress);

                Console.WriteLine(ip);


            } while (error);


            do
            {

                if (error)
                {
                    Console.WriteLine("\nPlease insert a valid ram size\n");
                }

                error = false;

                try
                {
                    Console.WriteLine("Insert the ram size in GB");
                    ram = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException)
                {
                    error = true;
                }
                catch (OverflowException)
                {
                    error = true;

                }

            } while (error);

            Console.WriteLine(ram);

        }


        static void Main(string[] args)
        {
            Hashtable computers = new Hashtable();

            

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
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:

                        

                        askValues(out string ip, out int ram);

                        computers.Add(ip, ram);

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
                        Console.WriteLine();
                        Console.WriteLine("+----------------+");
                        Console.WriteLine("| Invalid option |");
                        Console.WriteLine("+----------------+");
                        Console.WriteLine();
                        break;
                }
            } while (menu != 5);

        }
    }
}