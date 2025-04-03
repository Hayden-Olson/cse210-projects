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
        while (playerHealth > 0 && enemyHealth > 0)
        {
            _player.PlayerTurn();
            _enemy.EnemyTurn();
        }
        if (playerHealth == 0)
        {
            Console.WriteLine($"{player} has fallen in battle.");
            Console.WriteLine("Your journey ends here.");
        }
        else
        {
            Console.WriteLine($"The {enemy} has been slain.");
            Console.WriteLine("You won!");
        }
    }
}