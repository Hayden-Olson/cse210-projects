using System.Diagnostics;

public class Enemy : Character
{
    // This class will store all the information for the enemies in the game.

    public Enemy(string name, int health, Status status, Weapon weapon, int count) : base(name, health, status, weapon, count)
    {
        
    }

    public virtual void EnemyTurn(Player player)
    {
        string playerName = player.GetName();
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
                        player.Damage(attack);
                        Console.WriteLine($"{playerName} took {attack} damage!\n");
                        return;

                    // Enemy heals.
                    case 2:
                        Console.WriteLine($"{_name} heals!");
                        int heal = Heal();
                        Console.WriteLine($"{_name} recovered {heal} health!\n");
                        return;

                    // Enemy casts magic.
                    case 3:
                        Console.WriteLine($"{_name} casts a spell!");
                        int spell = new Random().Next(1,4);
                        switch (spell)
                        {
                            case 1:
                                Console.WriteLine($"{_name} casts fire! {playerName} is burned!\n");
                                player.SetStatus(MagicCast("fire"));
                                return;

                            case 2:
                                Console.WriteLine($"{_name} casts shock! {playerName} is paralyzed!\n");
                                player.SetStatus(MagicCast("shock"));
                                return;

                            case 3:
                                Console.WriteLine($"{_name} casts quake! {playerName} is now weak!\n");
                                player.SetStatus(MagicCast("quake"));
                                return;
                        }
                        return;
                }
            }
        }
    }
}