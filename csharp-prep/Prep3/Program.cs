using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int guess = 0; 
        while (guess != magicNumber)
        {
            // Ask for the user's guess
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
            
            // Check if the guess is higher, lower, or correct
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
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