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


    public void BattleSystem(Player player, string enemy)
    {
        foreach (int enemyId in enemyIds)
        {
            switch (enemyId)
            {
                case 0:
                Enemy goblin = new Enemy("Goblin", 45, new Weapon("club", 1, 13, 0, 5));
                enemies.Add(goblin);
                break;

                case 1:
                break;
            }
        }
        while (player.health > 0 && goblin.health > 0)
        {
            string player_turn = "none";
            string spell = "none";
            Console.WriteLine();
            Console.WriteLine("{name}:{hero_health} ({hero_status})         {enemy_name}:{enemy_health} ({enemy_status})");
            Console.WriteLine();
            
           
            if (hero_status == "Paralyzed")
            {
                roulette = Random.randint(1,2);
                if (roulette == 2)
                {
                    while (player_turn != "Attack" && player_turn != "Magic" && player_turn != "Heal")
                    {
                        Console.WriteLine("(Attack) (Magic) (Heal)");
                        Console.WriteLine("What will you do? ").capitalize();
                        player_turn = Console.ReadLine();
                        if (player_turn != "Attack" && player_turn != "Magic" && player_turn != "Heal")
                        {
                            Console.WriteLine($"{name}! Don't waste your move! Attack, use magic, or heal!");
                        }
                    }
                }
                else if (roulette == 1)
                {
                    Console.WriteLine($"{player.name} cannot move! ");
                    Console.ReadLine();
                }
                    
            }
            if (player_turn == "Attack")
            {
                damage = damage_inflicted(hero_weapon, hero_status);
                Console.WriteLine($"The {enemy_name} took {damage} damage!");
                enemy_health -= damage;
            }
            else if (player_turn == "Magic")
            {
                enemy_affliction = 0;
                while (spell != "Fire" and spell != "Shock" and spell != "Quake")
                {
                    Console.WriteLine("(Fire) (Shock) (Quake)");
                    Console.WriteLine("Which spell do you cast? ").capitalize();
                    spell = Console.ReadLine();
                    if (spell != "Fire" && spell != "Shock" && spell != "Quake")
                    {
                        Console.WriteLine($"That's not a spell {name}!");
                    }
                }
                    
                status_effect = status_effects(enemy_status, spell);
                enemy_status = status_effect;
                Console.WriteLine($"The {enemy_name} is now {enemy_status}!");
            }
                
            
            else if (player_turn == "Heal")
            {
                hero_health += restore_health();
                if (hero_health >= 150)
                {
                    hero_health = 150;
                    Console.WriteLine("Fully Recovered!");
                }
                    
                Console.WriteLine($"Your health is {hero_health}.");
            }
                
                
            if (hero_status == "Burned")
            {
                additional_damage = random.randint(1,5);
                Console.WriteLine($"{name} took {additional_damage} burning damage!");
                hero_health -= additional_damage;
            }
                
                
            if (hero_status != "Fine")
            {
                hero_affliction += 1;
                    if (hero_affliction == 3)
                    {
                        hero_affliction = 0;
                        hero_status = "Fine";
                        Console.WriteLine($"{name} is cured!");
                    }
                        
            }
                    
                //Enemy Turn
            Console.WriteLine();
            if (enemy_health > 0)
            {
                roulette = 2;
                if (enemy_status == "Paralyzed")
                {
                    roulette = random.randint(1,2);
                }
                    
                if (roulette == 2)
                {
                    Console.WriteLine($"{enemy_name} attacks!");
                    damage = damage_inflicted(enemy_weapon, enemy_status);
                    Console.WriteLine($"{name} took {damage} damage!");
                    hero_health -= damage;
                }
                    
                else
                {
                    Console.WriteLine($"The {enemy_name} couldn't move!");
                }
                    
                Console.WriteLine()
                if (enemy_status == "Burned")
                {
                    additional_damage = random.randint(1,5);
                    Console.WriteLine($"{enemy_name} took {additional_damage} burning damage!");
                    enemy_health -= additional_damage;
                }
                    
                if (enemy_status != "Fine")
                {
                    enemy_affliction += 1;
                    if (enemy_affliction == 3)
                    {
                        enemy_affliction = 0;
                        enemy_status = "Fine";
                        Console.WriteLine($"{enemy_name} is cured!");
                    }
                        
                }
            }
                
                    
        }
    
    if (hero_health <= 0)
    {
        Console.WriteLine("Your journey ends here.");
    }
       
    else
    {
        Console.Clear();
        Console.WriteLine("You won!");
        Console.WriteLine();
    }
        
    }
}