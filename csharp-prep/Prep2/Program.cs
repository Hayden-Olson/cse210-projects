using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string score = Console.ReadLine();
        int grade = int.Parse(score);
        int letter = grade % 10;
        string sign = "";
        if (letter >= 7)
        {
            if (grade >= 90 || grade < 60)
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
            
        else if (letter < 3)
        {
            if (grade >= 60)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        else
        {
            sign = "";
        }
           
        if (grade >= 90)
        {
            Console.WriteLine($"OUTSTANDING! You got an A{sign}!");
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine($"Great job! You got a B{sign}!");
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine($"You passed! You got a C{sign}.");
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine($"You were close! Better luck next time. You got a D{sign}.");
        }
        else if (!(grade >= 60))
        {
            Console.WriteLine($"You failed. You got a F{sign}.");
        }
        else
        {
            Console.WriteLine("How did you get here?");
        }
    }
}