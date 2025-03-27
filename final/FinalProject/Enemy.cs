using System.Diagnostics;

public class Enemy : Character
{
    // This class will store all the information for the enemies in the game.

    public Enemy(string name, int health, Status status, Weapon weapon) : base(name,health, status, weapon)
    {
        
    }

    public virtual void EnemyTurn()
    {
        if (_health > 0)
        {
            bool paralyzed = IsParalyzed();
            if (paralyzed == false)
            {
                int randomAction = new Random().Next(1, 4);
                switch (randomAction)
                {
                    case 1:
                        Console.WriteLine($"{_name} attacks!");
                        int damage = 
                        break;

                    case 2:

                        break;

                    case 3:

                        break;
                }
            }
            return;
        }
    }
}