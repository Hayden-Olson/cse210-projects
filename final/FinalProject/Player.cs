using System;

public class Player : Character
{
    // This is the class that stores the information for the users character.
   
    public Player(string name, int health, Status status, Weapon weapon) : base(name,150, Status.FINE, new Weapon("sword", 10, 30, 2, 16))
    {
  
    }

    public void PlayerTurn()
    {
        bool paralyzed = IsParalyzed();
        if (paralyzed == false)
        {
            string action = "";
            string spell = "";
            while (action != "attack" && action != "magic" && action != "heal")
            {
                Console.WriteLine($"(Attack) (Magic) (Heal)");
                Console.WriteLine("What will you do? ");
                action = Console.ReadLine();
                if (action != "attack" && action != "magic" && action != "heal")
                {
                    Console.WriteLine($"{_name}! Don't waste your move! Attack, use magic, or heal!");
                }
            }
            
            switch (action)
            {
                case "attack":
                    break;

                case "magic":
                    while (spell != "fire" && spell != "shock" && spell != "quake")
                    {
                        Console.WriteLine("(Fire) (Shock) (Quake)");
                        Console.WriteLine("Which spell do you cast? ");
                        spell = Console.ReadLine();
                        if (spell != "fire" && spell != "shock" && spell != "quake")
                        {
                            Console.WriteLine($"That is not a spell {_name}!\n");
                        }
                    }
                    MagicCast(spell);
                    break;

                case "heal":
                    Heal();
                    break;
            }
        }
        return;
    }
}