using System;

class Program
{
    static void Main(string[] args)
    {
        // Not adj. We want the variable to be clear.
        string adjective = GetAdjective();
        string noun = GetNoun();

        int number = Multiply(3,4);

        Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}s.");
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("yellow");
        words.Add("big");
        words.Add("small");
        
    }
    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;

        return product;
    }
    static string GetAdjective()
    {
        string adjective = "yellow";

        return adjective;
    }
    static string GetNoun()
    {
        string word = "bird";

        return word;
    }
}