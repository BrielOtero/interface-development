using System.Xml.Linq;

namespace _01_02_03_04_exercise
{

    internal class Program
    {
        private static void companyEarnings(IGoosePasta iGoosePasta)
        {
            Console.WriteLine("Insert Company Earnings");
            Console.WriteLine("Win Pasta: " + iGoosePasta.WinPasta(Convert.ToInt32(Console.ReadLine())));
        }
        static void Main(string[] args)
        {

            Employee employee = new Employee("Manolo", "Sanchez", 22, "33144756C", 25000, "614567426");
            Executive executive = new Executive("Paco", "Martinez", 50, "23148944E", "Contabilidad", 3);
            SpecialEmployee specialEmployee = new SpecialEmployee("Laura", "Rodriguez", 43, "31134576U", 30000, "634544456");

            int menu;
            do
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine();
                Console.WriteLine("1. Show values executive");
                Console.WriteLine("2. Show values employee");
                Console.WriteLine("3. Show values special employee");
                Console.WriteLine("4. Exit");
                menu = Convert.ToInt16(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        executive.ShowValues();
                        companyEarnings(executive);
                        Console.WriteLine("Tax Authorities: " + executive.TaxAuthorities());


                        break;
                    case 2:
                        Console.Clear();
                        employee.ShowValues();
                        Console.WriteLine("Tax Authorities: " + employee.TaxAuthorities());


                        break;
                    case 3:
                        Console.Clear();
                        specialEmployee.ShowValues();
                        companyEarnings(specialEmployee);
                        Console.WriteLine("Tax Authorities: " + specialEmployee.TaxAuthorities());


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