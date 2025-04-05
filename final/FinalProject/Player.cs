using System;

public class Player : Character
{
    // This is the class that stores the information for the users character.
    
    private bool _alive = true;
    //                      Name   Health   Status       Weapon/Damage                 StatusCount
    public Player() : base(SetName(),150, Status.FINE, new Weapon("sword", 10, 30, 2, 16), 0)
    {

    }

    // This bool is used to set up the fail state. Otherwise, _alive is always true.
    public void SetIsAlive(bool alive)
    {
        _alive = alive;
    }

    // Returns the _alive bool.
    public bool GetIsAlive()
    {
        return _alive;
    }

    // The players turn is handled in this class. It simply displays available actions then returns their choice.
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

                // Ensures the player puts in a proper action.
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