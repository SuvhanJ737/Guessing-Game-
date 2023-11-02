using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "Suvahn";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;

            //WHILE LOOP

            if (guessCount < guessLimit && !outOfGuess) //if both conditions false we break out of loop
            {
                while (guess != secretWord)
                {
                    Console.Write("Please Enter Guess: ");
                    guess = (Console.ReadLine());
                    guessCount++;
                }
            }
            else
            {
                outOfGuess = true; //boolen flag - value giving a piece of info
                                   // if they guess 3 times then it will set to true
            }

            if (outOfGuess)
            {
                Console.WriteLine("You Lose!"); //if outOfGuess is true
            }
            else
            {
                Console.WriteLine("You Win!");
            }


            Console.ReadLine();

        }
    }
}
//-----------------------------------------------------------------------
            /*
            DO WHILE LOOP
            do
            {
                Console.Write("Please Enter Guess: ");
                guess = (Console.ReadLine());
            } while (guess != secretWord);

            Console.WriteLine("You Win!");

             */








            
