using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int userInput = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        // We could also use a do-while loop here...
        while (guessNumber != randomNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (randomNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }          
        }
    }
}