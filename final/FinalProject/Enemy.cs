using System.Diagnostics;

public class Enemy : Character
{
    // This class will store all the information for the enemies in the game.

    public Enemy(string name, int health, Status status, Weapon weapon) : base(name, health, status, weapon)
    {
        
    }

    public virtual int EnemyTurn()
    {
        if (_health > 0)
        {
            bool paralyzed = IsParalyzed();
            if (paralyzed == false)
            {
                int randomAction = new Random().Next(1, 4);
                switch (randomAction)
                {
                    // Enemy does a normal attack.
                    case 1:
                        Console.WriteLine($"{_name} attacks!");
                        int attack = _weapon.GetDamage(this);
                        return attack;

                    // Enemy heals.
                    case 2:
                        Console.WriteLine($"{_name} heals!");
                        Heal();
                        return 0;

                    // Enemy casts magic.
                    case 3:
                        int spell = new Random().Next(1,4);
                        switch (spell)
                        {
                            case 1:
                                MagicCast("fire");
                                return 0;

                            case 2:
                                MagicCast("shock");
                                return 0;

                            case 3:
                                MagicCast("quake");
                                return 0;
                        }
                        return 0;
                }
            }
            return 0;
        }
        Console.WriteLine($"The {_name} has been slain!");
        return 0;
    }
}