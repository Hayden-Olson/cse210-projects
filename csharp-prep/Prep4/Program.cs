using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        
        int userNumber = -1;
        
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(numbers.Count);
        int amount = int.Parse(Console.ReadLine());

        float average = 0;
        foreach (int number in numbers)
        {
            average += number;
            average /= amount;
        }
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
            if (number > 0 || number < 0)
            {
                Console.WriteLine(number);
            }
    }
}