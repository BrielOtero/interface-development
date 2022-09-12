using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 10, b = 3, totalsuma, totalresta;
            string moneda;
            totalsuma = a + b;
            totalresta = a - b;
            moneda = "Euros";
            Console.WriteLine("El valor {0} sumado con el {1} resulta un total de {2} {3}. Pero dicho valor {0} si se le resta {1} queda un total de {4} {3}\n", a, b, totalsuma, moneda, totalresta);


            string nom;
            Console.WriteLine("Por favor introduce tu nombre");
            nom = Console.ReadLine();
            switch (nom)
            {
                case "adios":
                case "Adios":
                case "ADIOS":
                    Console.WriteLine("Hasta la próxima");
                    break;
                case "Curro":
                    Console.WriteLine("Acceso denegado, cámbiate el nombre");
                    goto case "ADIOS";
                default:
                    Console.WriteLine("Hola {0}, bienvenido a este programa",
                   nom);
                    break;
            }

        }
    }
}