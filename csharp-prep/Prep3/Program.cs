using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Creating magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        // Call and Response loop
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        } while (magicNumber != guess);
    }
}