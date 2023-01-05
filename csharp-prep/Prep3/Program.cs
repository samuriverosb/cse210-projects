using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 100);
        int guessNumber;
        int guesses = 0;


        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if (guessNumber < randomNumber)
            {
                Console.WriteLine("Higher");
                guesses += 1;
            }
            else if (guessNumber > randomNumber)
            {
                Console.WriteLine("Lower");
                guesses += 1;
            }
            else
            {
                guesses += 1;
                Console.WriteLine($"You guessed it! It took you {guesses} intents");
            }
        } while (guessNumber != randomNumber);

    }
}