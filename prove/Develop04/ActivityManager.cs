using System;

public class ActivityManager
{
    private const string CHOICE_BREATH = "1";
    private const string CHOICE_REFLECT = "2";
    private const string CHOICE_LIST = "3";
    private const string CHOICE_QUIT = "4";

    private BreathingActivity _breathingActivity = new BreathingActivity();
    private ListingActivity _listingActivity = new ListingActivity();
    private ReflectingActivity _reflectingActivity = new ReflectingActivity();

    public void RunSession()
    {
        string choice;
        int count = 0;

        do
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case CHOICE_BREATH:
                    _breathingActivity.Run();
                    break;

                case CHOICE_REFLECT:
                    _reflectingActivity.Run();
                    break;

                case CHOICE_LIST:
                    _listingActivity.Run();
                    break;

                case CHOICE_QUIT:
                    break;

                default: 
                    Console.WriteLine("Input not recognized. Try again.");
                    break;
            }
            // This is the check to make sure the count only increases when activities are selected.
            int num = int.Parse(choice);
            if (0 < num && num < 4)
                {
                    count++;
                }
        }
        while (choice != CHOICE_QUIT);
        // This message will display the amount of activities you did in one session, not including the quit.
        Console.WriteLine($"You did {count} activities! Great work!");
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("    1. Start breathing activity");
        Console.WriteLine("    2. Start reflecting activity");
        Console.WriteLine("    3. Start listing activity");
        Console.WriteLine("    4. Quit");
    }
}