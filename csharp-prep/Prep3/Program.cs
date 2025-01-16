using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            int guess = -1;
            int attempt = 0;
            Console.WriteLine("What is the magic number?");
            while (guess != number);
                attempt += 1;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            if (attempt > 1)
            {
                Console.WriteLine($"It took you {attempt} tries!");
            }
            else if (attempt == 1)
            {
                Console.WriteLine("First try!");
            }
            Console.Write("Do you wanna play again? (yes/no) ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}