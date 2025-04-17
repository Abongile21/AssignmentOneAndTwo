using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneAndTwo
{

    class GuessTheNumber
    {
        private int secretNumber;
        private int attempts;

        public GuessTheNumber()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;
        }
        
        public void CheckGuess(int guess)
        {
            attempts++;

            if (guess < secretNumber)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Too low.");

            }
            else if (guess > secretNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Too high.");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Correct! You guessed the number in {attempts} attempt{(attempts == 1 ? "" : "s")}.");
                
            }
            Console.Beep();
            Console.ResetColor();
        }

        public void Play()
        {
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 100.");
            Console.WriteLine("Type 'exit' to quit the game.\n");

            while (true)
            {
                Console.Write("Your guess: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Game exited. Thanks for playing!");
                    Console.Beep();
                    break;
                }

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor= ConsoleColor.Red;

                    Console.WriteLine("Please enter a valid number.");
                    Console.ResetColor();
                    Console.Beep();
                    continue;
                }

                CheckGuess(guess);
             

                if (guess == secretNumber)
                    break;
            }
        }
    }     
}
