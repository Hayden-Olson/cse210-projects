using System.ComponentModel;
using System.Diagnostics;

public class Battle
{
    // This class runs the battle system. This class is the bulk of the program, calling just about every other class.
    // This will be used at least four times throughout the program, so storing it separate from the main program saves a lot of space.
    private Player _player;
    private Enemy _enemy;

    public Battle(Player player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    public void BattleSystem(Player player, Enemy enemy)
    {
        string playerName = player.GetName();
        string enemyName = enemy.GetName();
        Weapon playerWeapon = player.GetWeapon();

        while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
        {
            Console.Clear();
            Console.WriteLine($"{playerName}:{player.GetHealth()} ({player.GetStatus()}) || {enemyName}:{enemy.GetHealth()} ({enemy.GetStatus()})");
            string action = _player.PlayerTurn();
            string spell = "";
            switch (action)
            {
                case "attack":
                    Console.WriteLine($"{playerName} attacks!");
                    int playerDamage = playerWeapon.GetDamage(player);
                    enemy.Damage(playerDamage);
                    Console.WriteLine($"{enemyName} takes {playerDamage} damage!\n");
                    break;

                case "magic":
                    while (spell != "fire" && spell != "shock" && spell != "quake")
                    {
                        Console.WriteLine("(Fire) (Shock) (Quake)\n");
                        Console.Write("Which spell do you cast? ");
                        spell = Console.ReadLine();
                        if (spell != "fire" && spell != "shock" && spell != "quake")
                        {
                            Console.WriteLine($"That is not a spell {playerName}!\n");
                        }
                    }
                    enemy.SetStatus(player.MagicCast(spell));
                    Console.WriteLine($"{enemyName} is now {enemy.GetStatus()}!\n");
                    break;

                case "heal":
                    Console.WriteLine($"{playerName} heals {player.Heal()} health!\n");
                    break;
            }
            
            // Player takes damage after their turn if their status is BURNED. All status effects only last 3 turns.
            player.IsBurned();
            _player.FeelingBetter();
        
            // Enemies turn is handled in the Enemy class.
            _enemy.EnemyTurn(player);

            // Enemy takes damage after their turn if their status is BURNED. All status effects only last 3 turns.
            enemy.IsBurned();
            _enemy.FeelingBetter();

            Console.Write("*******************************************************************************************");
            Console.ReadLine();
            Console.Clear();
        }
        if (player.GetHealth() <= 0)
        {
            Console.WriteLine($"{playerName} has fallen in battle.");
            Console.WriteLine("Your journey ends here.");
            Console.Write("*******************************************************************************************");
            Console.ReadLine();
            player.SetIsAlive(false);
        }
        else
        {
            Console.WriteLine($"The {enemyName} has been slain!\n");
            Console.WriteLine("You won!");
            Console.Write("*******************************************************************************************");
            Console.ReadLine();
        }
    }
}