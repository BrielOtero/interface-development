using System.Xml.Linq;

namespace _01_02_03_04_exercise
{

    internal class Program
    {
        private static void companyEarnings(IGoosePasta iGoosePasta)
        {
            Console.WriteLine("Insert Company Earnings");
            Console.WriteLine(iGoosePasta.WinPasta(Convert.ToInt16(Console.ReadLine())));
        }
        static void Main(string[] args)
        {

            Employee employee = new Employee("Manolo", "Sanchez", 22, "33144756C", 25000, 8, "614567426");
            Executive executive = new Executive("Paco", "Martinez", 50, "23148944E", "Contabilidad",3);
            SpecialEmployee specialEmployee = new SpecialEmployee();

            int menu;
            do
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine();
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("4.");
                Console.WriteLine("5.Exit");
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        executive.ShowValues();

                        break;
                    case 2:
                        employee.ShowValues();

                        break;
                    case 3:
                        specialEmployee.ShowValues();

                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("+----------------+");
                        Console.WriteLine("| Invalid option |");
                        Console.WriteLine("+----------------+");
                        Console.WriteLine();
                        break;
                }
            } while (menu != 4);
        }
    }
}