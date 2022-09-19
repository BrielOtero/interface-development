using System.Diagnostics;
using System.Reflection.Emit;

namespace _04_exercise
{
    internal class Program
    {
        public static void PaintMenu(string[] options, int option)
        {
            string titulo = "MENU";

            Console.Clear();
            Console.WriteLine(titulo);
            for (int i = 0; i < options.Length; i++)
            {
                if (i == option)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(options[i]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        public static void Menu()
        {
            int option = 0;
            bool returnToMenu;
            int select = -1;
            string[] options = { "1-. Launch dice", "2-. Guess number", "3-. Football pools", "4-. Play all", "5-. Exit" };
            Console.CursorVisible = false;
            PaintMenu(options, option);
            ConsoleKeyInfo tecla;

            do
            {

                returnToMenu = true;
                tecla = Console.ReadKey();

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
                        break;

                    case ConsoleKey.Escape:
                        select = options.Length - 1;
                        break;

                }

                PaintMenu(options, option);





            } while (select == -1);


            switch (select)
            {
                case 0:
                    launchDice(returnToMenu);

                    if (!returnToMenu)
                    {
                        goto case 1;
                    }

                    break;
                case 1:
                    guessNum(returnToMenu);

                    if (!returnToMenu)
                    {
                        goto case 2;
                    }

                    break;

                case 2:
                    footballPool(true);

                    break;
                case 3:
                    returnToMenu = false;

                    goto case 0;

                case 4:
                    break;
            }

            //Console.Clear();
            //Console.ReadLine();

        }

        private static void launchDice(bool returnTuMenu)
        {
            Console.Clear();

            bool isValid;
            int dice = 0;
            int luckyNumber = 0;
            int random = 0;

            do
            {
                isValid = true;
                Console.WriteLine("Insert the numbers of the dice faces :");
                string diceFaces = Console.ReadLine();
                Console.WriteLine("Insert your lucky number:");
                string luckyNum = Console.ReadLine();

                try
                {
                    dice = Convert.ToInt16(diceFaces);
                    luckyNumber = Convert.ToInt16(luckyNum);

                    if ((luckyNumber < 0 || luckyNumber > dice) || dice > int.MaxValue)
                    {
                        isValid = false;
                        Console.Clear();
                        Console.WriteLine("Incorrect values");
                    }
                }
                catch (FormatException)
                {
                    isValid = false;
                    Console.Clear();
                    Console.WriteLine("Incorrect values");
                }

            } while (!isValid);

            Random rand = new Random();
            int hit = 0;

            for (int i = 0; i < 10; i++)
            {
                random = rand.Next(dice + 1);
                Console.WriteLine("Number {0}", random);

                if (random == luckyNumber)
                {
                    hit++;
                }

            }

            Console.WriteLine("You guess {0} numbers", hit);


            returnToMenu(returnTuMenu);

        }

       private static void guessNum(bool returnTuMenu)
        {
            int randNum = 0;
            int userNum = 0;
            int tries = 5;
            Random rand = new Random();
            randNum = rand.Next(1, 101);
            bool wasGuessed = false;

            Console.Clear();
            Console.WriteLine("Guess the number\n\n");


            while (!wasGuessed)
            {
                Console.WriteLine("You has {0} tries", tries);
                Console.WriteLine("Insert number:");
                try
                {
                    do
                    {
                        userNum = Convert.ToInt16(Console.ReadLine());

                    } while (userNum > 100 || userNum < 1);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Values not valid");
                }

                tries--;


                if (userNum > randNum)
                {
                    Console.Clear();
                    Console.WriteLine("The number it's below");
                }
                else if (userNum < randNum)
                {
                    Console.Clear();
                    Console.WriteLine("The number it's on top");

                }
                else
                {
                    Console.Clear();
                    wasGuessed = true;
                    Console.WriteLine("You're right!!");
                    Console.WriteLine("The number was {0}", randNum);

                    tries = -1;
                }

                if (tries == 0)
                {
                    Console.Clear();
                    wasGuessed = true;
                    Console.WriteLine("You're Lost! :(");
                    Console.WriteLine("The number was {0}", randNum);
                }
            }

            if (tries <= 0)
            {
                returnToMenu(returnTuMenu);
            }
        }

       private static void footballPool(bool returnTuMenu)
        {
            Random rand = new Random();
            int randNum;
            string value = "";
            string[] results = new string[14];

            Console.Clear();
            Console.WriteLine("Football Pool");
            for (int i = 0; i < results.Length; i++)
            {
                randNum = rand.Next(101);

                switch (randNum)
                {
                    case < 60:
                        value = "1";
                        break;

                    case >= 60 and <= 85:
                        value = "x";
                        break;

                    case > 85:
                        value = "2";
                        break;

                }

                results[i] = value;

                Console.WriteLine("{0,2} | {1,2}", i + 1, value);

            }
            returnToMenu(returnTuMenu);

        }

      private static void returnToMenu(bool returnTuMenu)
        {
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();

            if (returnTuMenu)
            {
                Menu();
            }



        }

        static void Main(string[] args)
        {
            Menu();

        }
    }
}