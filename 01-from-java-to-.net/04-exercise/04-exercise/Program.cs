namespace _04_exercise
{
    internal class Program
    {
        static void paintMenu(string[] options, int option)
        {

        }

        static void Main(string[] args)
        {
            int option = 0;
            int select = -1;
            string[] options = { "1-. Launch dice", "2-. Guess number", "3-. Football pools", "4-. Play all", "5-. Exit" };
            Console.CursorVisible = false;
            paintMenu(options, option);

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

                    case ConsoleKey.Spacebar:
                        select = option;
                        break;
                    case ConsoleKey.Escape:
                        select = options.Length - 1;
                        break;

                }
                paintMenu(options, select);
                Console.WriteLine
            }

                
        }
    }
}