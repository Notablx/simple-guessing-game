using System;
using System.Threading;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            string[] words = {"cool", "epic", "guess"};
            Random random = new Random();
            bool haslost = false;
            int secretwordguess = random.Next(0, 3);
            int guesscount = 0;
            int guesslimit = 3;
            string guess = "";
            string secretword = words[secretwordguess];
            while (guess != secretword & !haslost)
            {
                if (guesscount != guesslimit)
                {
                    Console.Write("Guess: ");
                    guess = Console.ReadLine().ToLower();
                    guesscount++;
                }
                else
                {
                    haslost = true;
                }
            }
            if (!haslost)
            {
                Console.WriteLine("You Won!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("You Lost!");
                Console.WriteLine("The word was: " + secretword);
                Thread.Sleep(3000);
            }
        }
    }
}