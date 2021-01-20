using System;

namespace Lab_3___Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.WriteLine("Grand Circus -- Lab 2 -- Ramon Guarnes's Room Calculator: \n");

            //NAME INPUT
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            //CONTINUE FLAG
            char checkFlag = 'y';

            do
            {
                //NUMBER INPUT
                Console.WriteLine("\nHello " + name + ". Please enter a number between 1 and 100:");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                //NUMBER OUT OF BOUNDS, TRY AGAIN
                while (number <= 1 || number >= 100)
                {
                    Console.WriteLine("\nNumber MUST be BETWEEN 1 and 100. Try again " + name + ":");
                    input = Console.ReadLine();
                    number = int.Parse(input);
                }

                //NUMBER IS EVEN
                if (number % 2 == 0)
                {
                    // INTEGER IS EVEN, RANGE 2 - 25
                    if (number >= 2 && number <= 25)
                    {
                        Console.WriteLine("\n" + name + "'s Output: Even and less than 25.\n");
                    }
                    // INTEGER IS EVEN, RANGE 26 - 60
                    if (number >= 26 && number <= 60)
                    {
                        Console.WriteLine("\n" + name + "'s Output: Even.\n");
                    }
                    // INTEGER IS EVEN, RANGE 60 - 99
                    if (number > 60)
                    {
                        Console.WriteLine("\n" + name + "'s Output: " + number + " and Even.\n");
                    }
                }
                //NUMBER IS ODD
                else
                {
                    Console.WriteLine("\n" + name + "'s Output: " + number + " and Odd.\n");
                }

                //ASK USER IF CONTINUE/RETRY
                Console.WriteLine("Would you like to continue " + name + "? (y/n)");
                checkFlag = Console.ReadLine()[0];
            } while (checkFlag == 'y');

            //PROGRAM ENDED
            Console.WriteLine("\nThe program has quitting. Thank you for joining us " + name);
        }
    }
}
