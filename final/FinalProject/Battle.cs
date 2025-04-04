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
        int playerHealth = _player.GetHealth();
        int enemyHealth = _enemy.GetHealth();
        string playerName = player.GetName();
        string enemyName = enemy.GetName();
        Status playerStatus = player.GetStatus();
        Status enemyStatus = enemy.GetStatus();
        Weapon playerDamage = Weapon.GetDamage(player);
        Weapon enemyDamage = Weapon.GetDamage(enemy);

        while (playerHealth > 0 && enemyHealth > 0)
        {
            Console.WriteLine($"{playerName}:{playerHealth} ({playerStatus}) || {enemyName}:{enemyHealth} ({enemyStatus})");
            string action = _player.PlayerTurn();
            string spell = "";
            switch (action)
            {
                case "attack":
                    Console.WriteLine($"{playerName} attacks!");
                    Console.WriteLine($"{enemyName} takes");
                    enemyHealth --;
                    break;

                case "magic":
                    while (spell != "fire" && spell != "shock" && spell != "quake")
                    {
                        Console.WriteLine("(Fire) (Shock) (Quake)");
                        Console.WriteLine("Which spell do you cast? ");
                        spell = Console.ReadLine();
                        if (spell != "fire" && spell != "shock" && spell != "quake")
                        {
                            Console.WriteLine($"That is not a spell {playerName}!\n");
                        }
                    }
                    player.MagicCast(spell);
                    break;

                case "heal":
                    player.Heal();
                    break;
            }
        
            _enemy.EnemyTurn();
        }
        if (playerHealth == 0)
        {
            Console.WriteLine($"{player} has fallen in battle.");
            Console.WriteLine("Your journey ends here.");
        }
        else
        {
            Console.WriteLine("You won!");
        }
    }
}