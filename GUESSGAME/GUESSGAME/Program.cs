using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUESSGAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Duck";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuess=false;
            Console.WriteLine("Hint:Ayush Discord Name:");

            while (guess!=secretWord && !outOfGuess)
            {
                if (guessCount <guessLimit)
                { 
                    Console.Write("Enter Guess:");
                    guess = Console.ReadLine();
                    guessCount++;
                    if(guess==secretWord)
                    {
                        Console.WriteLine("Yay!You win.");
                    }

                }
                else if(guessCount==guessLimit)
                {
                    outOfGuess = true;
                }
            }
            if(outOfGuess)
            {
                Console.WriteLine("You lost!Run program to try again");
            }
            Console.ReadKey();
        }
    }
}
