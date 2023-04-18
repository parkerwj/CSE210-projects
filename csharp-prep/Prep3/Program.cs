using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            // Generate a random number and ask the user to guess the number.
            // Provide feedback if the number is higher or lower. 
            // Loop the program while replay is "y".
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int numberGuesses = 0;
            Console.WriteLine($"Guess the magic number? ");
            while (magicNumber != userGuess)
            {
                Console.Write("What is your guess? ");
                string userString = Console.ReadLine();
                userGuess = int.Parse(userString);
                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");
                }
            numberGuesses ++;    
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {numberGuesses} guesses.");
            Console.WriteLine("Do you want to play again? (y/n)");
            response = Console.ReadLine();
        } while (response == "y"); 
    Console.WriteLine("Thanks for playing!");
    }
}