using System.IO.Pipes;
using System.Xml.Serialization;

public class Activity
{
    protected string _startingMessage;
    protected string _name;

    protected Activity(string name, string startingMessage)
    {
        _name = name;
        _startingMessage = startingMessage;
    }

    public void ShowSpinner()
    {
        int count = 0;
        while (count != 3)
        {
            Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the | character
            Console.Write("/"); // Replace it with the / character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the / character
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the - character
            Console.Write("\\"); // Replace it with the \ character

            Thread.Sleep(500);

            Console.Write("\b \b");

            count += 1;
        }

    }

    public int ShowIntro()
    {
        Console.Clear();
        Console.WriteLine($"This is the {_name}!");
        Console.WriteLine (_startingMessage);

        int pace = GetTime();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner();
        return pace;
    }

    public int GetTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string pace = Console.ReadLine();
        return int.Parse(pace);
    }

    public void ShowCountdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // addon is there in case a third message needs to be displayed at the end. This is used only in the Listing Activity right now, but if another program wanted to convey a special message, then they would put it in the addon spot for the third input parameter.
    public void ShowEnding(int timeSpent, string addon = "")
    {
        Console.WriteLine("");
        Console.WriteLine("You did a great job!");
        ShowSpinner();
        Console.WriteLine($"You completed the {_name} in {timeSpent} seconds!");
        Console.WriteLine(addon);
        ShowSpinner();
        Console.Clear();
    }
}