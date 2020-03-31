using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_collaboration_project_part_1
{
    class Program
    {
        static void Main(string[] args)
        {


          int  number = 4;
          int  guesscount = 0;
          int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10: ");
            guess = Int32.Parse(Console.ReadLine());
            guesscount = guesscount + 1;
            while (guess != number) 
            {

                if (guess < number)

                    Console.WriteLine("Your guess is too low");

                else if (guess > number)

                    Console.WriteLine("Your guess is too high");

                else
                {
                    Console.WriteLine("You got it!!");
                    
                }
                Console.WriteLine("Guess again: ");
                guess = Int32.Parse(Console.ReadLine());
                guesscount = guesscount + 1;
                //ask user for input again

            }


            Console.WriteLine("You figured it out in {0} guesses. ", guesscount);
            Console.ReadLine();


        }
    }
}
