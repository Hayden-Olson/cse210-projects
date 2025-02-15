using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
    
        Scripture scripture = new ScriptureLibrary().GetScriptures();
        while (answer != "quit")
        {
            scripture.Display();

            answer = Console.ReadLine();

            bool allHidden = scripture.IsAllHidden();

            if (allHidden == true)
            {
                break;
            }

            else
            {
                scripture.HideWords();
            }
            Console.Clear();
        }
    }
}