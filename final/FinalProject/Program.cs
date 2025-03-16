using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello adventurer! What is your name? ");
        string playerName = Console.ReadLine();
        Player player = new Player(playerName);
        playerName = player.GetPlayerName();
        Console.WriteLine($"{playerName}! You set off on your quest to vanquish the demon who torments your land!");
        Console.WriteLine("As you make your way down the path through the woods, a Goblin emerges and attacks you!");
        Battle battle1 = new Battle();
        battle1.BattleSystem(playerName, ListName.GetEnemyName(0));
    }
}