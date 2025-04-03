public class Brute : Enemy
{
    public Brute() : base("Brute", 75, Status.FINE, new Weapon("knife", 15, 19, 3, 10))
    {
       
    }

    public override int EnemyTurn()
    {
        if (_health > 0)
        {
            bool paralyzed = IsParalyzed();
            if (paralyzed == false)
            {
                int randomAction = new Random().Next(1, 3);
                switch (randomAction)
                {
                    // Enemy does a normal attack.
                    case 1:
                        Console.WriteLine($"{_name} attacks!");
                        int attack = _weapon.GetDamage(this);
                        return attack;

                    // Enemy heals.
                    case 2:
                        Console.WriteLine($"{_name} heals!");
                        Heal();
                        return 0;
                }
            }
            return 0;
        }
        Console.WriteLine($"The {_name} has been slain!");
        return 0;
    }
}