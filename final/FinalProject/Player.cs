using System;

public class Player : Character
{
    // This is the class that stores the information for the users character.
   
    public Player() : base(SetName(),150, Status.FINE, new Weapon("sword", 10, 30, 2, 16))
    {

    }

    public static string SetName()
    {
        Console.Write("Hello adventurer! What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("");
        return name;
    }

    public string PlayerTurn()
    {
        string action = "";
        bool paralyzed = IsParalyzed();
        if (paralyzed == false)
        {
            while (action != "attack" && action != "magic" && action != "heal")
            {
                Console.WriteLine("(Attack) (Magic) (Heal)\n");
                Console.Write("What will you do? ");
                action = Console.ReadLine();
                Console.WriteLine("");
                if (action != "attack" && action != "magic" && action != "heal")
                {
                    Console.WriteLine($"{_name}! Don't waste your move! Attack, use magic, or heal!\n");
                }
            }
            
            return action;
        }
        return action;
    }   
}