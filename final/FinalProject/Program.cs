using System;

class Program
{
    static void Main(string[] args)
    {
        // This sets up all the characters for the game.
        Player player = new Player();
        Goblin goblin = new Goblin();
        Brute brute = new Brute();
        Doppleganger doppleganger = new Doppleganger();
        Demon demon = new Demon();

        // Player is able to name their hero.
        string playerName = player.GetName();

        // First scenario plays here.
        Console.WriteLine($"{playerName}! You set off on your quest to vanquish the demon who torments your land!");
        Console.WriteLine("As you make your way down the path through the woods, a Goblin emerges and attacks you!");
        Battle battle1 = new Battle(player, goblin);
        battle1.BattleSystem(player, goblin);

        Battle battle2 = new Battle(player, brute);
        battle2.BattleSystem(player, brute);

        Battle battle3 = new Battle(player, doppleganger);
        battle3.BattleSystem(player, doppleganger);

        Battle battle4 = new Battle(player, demon);
        battle4.BattleSystem(player, demon);
    }
}