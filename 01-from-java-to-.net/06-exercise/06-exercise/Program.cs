//#define WORK

namespace _06_exercise

{
    internal class Program
    {
        private static void randomPaint(int asterisks = 10)
        {
            Random r = new Random();

            int left = r.Next(1, 11);
            int top = r.Next(1, 21);


            for (int i = 0; i < asterisks; i++)
            {
                Console.SetCursorPosition(left, top);
                Console.Write("*");
                left++;

            }
        }

        private static bool factorial(int number, ref int fact)
        {
            if (number < 0 || number > 10)
            {
                return false;
            }


            int i = number;

            while (number != number / i)
            {
                fact = fact * i;
                i--;
            }

            return true;
        }

        static void Main(string[] args)
        {
#if WORK
            int fact = 1;
            factorial(5, ref fact);
            Console.WriteLine(fact);
#else
            randomPaint();

#endif
        }
    }
}