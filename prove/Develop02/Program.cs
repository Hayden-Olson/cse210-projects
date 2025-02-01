using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine(" 1. Write a new entry.");
        Console.WriteLine(" 2. Display journal.");
        Console.WriteLine(" 3. Save file.");
        Console.WriteLine(" 4. Load file.");
        Console.WriteLine(" 5. Delete entry.");
        Console.WriteLine(" 6. Quit.");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        string userChoice = "";
        PromptGenerator.Init();
        Journal journal;
        journal = new Journal();

        do
        {
            DisplayMenu();
            Console.Write("What do you want to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Entry newEntry = new Entry();

                newEntry.GetFromUser();

                journal.AddEntry(newEntry);

                Console.WriteLine();
            }

            else if (userChoice == "2")
            {
                journal.Display();
            }

            else if (userChoice == "3")
            {
                journal.SaveToFile();
            }

            else if (userChoice == "4")
            {
                journal.LoadFromFile();
            }

            else if (userChoice == "5")
            {
                journal.RemoveEntry();
            }

            else if (userChoice != "6")
            {
                Console.WriteLine();
                Console.WriteLine("Only type numbers 1 - 6.");
                Console.WriteLine();
            }

        }
        while (userChoice != "6");

    }
}