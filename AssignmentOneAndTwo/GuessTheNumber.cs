using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOneAndTwo
{

    class GuessTheGame
    {
        private int secretNumber;
        private int attempts;

        public GuessTheGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;
        }

        public string CheckGuess(int guess)
        {
            attempts++;

            if (guess < secretNumber)
                return "Too low.";
            else if (guess > secretNumber)
                return "Too high.";
            else
                return $"Correct! You guessed the number in {attempts} attempt{(attempts == 1 ? "" : "s")}.";
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
                    break;
                }

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                string result = CheckGuess(guess);
                Console.WriteLine(result);

                if (guess == secretNumber)
                    break;
            }
        }
    }     
}
