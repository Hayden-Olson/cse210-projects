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
        Console.Write("*******************************************************************************************");
        Console.ReadLine();
        Battle battle1 = new Battle(player, goblin);
        battle1.BattleSystem(player, goblin);

        Console.WriteLine($"{playerName} makes it through the woods successfully.");
        Console.WriteLine($"A mountain now stands between you and the demons lair.");
        Console.WriteLine("A brute in waiting attempts to rob you!");
        Battle battle2 = new Battle(player, brute);
        battle2.BattleSystem(player, brute);

        Console.WriteLine($"{playerName} travels up the perilous peaks.");
        Console.WriteLine("You can see the demons lair off in the distance!");
        Console.WriteLine("A Doppleganger appears from the shadows and takes your form.");
        Console.WriteLine($"DoppleGanger: Show me what you got {playerName}.");
        Battle battle3 = new Battle(player, doppleganger);
        battle3.BattleSystem(player, doppleganger);

        Console.WriteLine($"{playerName}'s doppleganger diminishes back into the shadows.");
        Console.WriteLine($"{playerName} prepares for the final battle within the lair then walks in.");
        Console.WriteLine($"{playerName} charges in and shouts at the demon:");
        Console.WriteLine("Your reign of terror ends here!");
        Battle battle4 = new Battle(player, demon);
        battle4.BattleSystem(player, demon);

        Console.WriteLine("The demon roars as it fades away.");
        Console.WriteLine($"{playerName}! You have vanquished the evil demon!");
        Console.WriteLine("Having taken down the greatest evil,");
        Console.WriteLine($"{playerName} makes their way back home to get some good sleep.");
        Console.WriteLine("Quest Over. Congratulations!");
    }
}