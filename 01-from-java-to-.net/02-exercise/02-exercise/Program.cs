#define FRASE
namespace _02_exercise
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Insert first sentence");
            string sentence1 = Console.ReadLine();
            Console.WriteLine("Insert second sentence");
            string sentence2 = Console.ReadLine();


#if FRASE
            Console.WriteLine(String.Format("{0}\t{1}\n{0}\n{1}", sentence1,sentence2));
#else
            Console.WriteLine(String.Format("\"{0}\"\t\\{1}\\", sentence1,sentence2));


#endif



        }
    }
}