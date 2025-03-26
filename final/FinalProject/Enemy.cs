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
            int random = new Random().Next(1, 5);
            switch (random)
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;
            }
        }
    }
}