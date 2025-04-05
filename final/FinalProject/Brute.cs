public class Brute : Enemy
{
    public Brute() : base("Brute", 75, Status.FINE, new Weapon("knife", 15, 19, 3, 10))
    {
       
    }

    public override void EnemyTurn(Player player)
    {
        string playerName = player.GetName();
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
                        player.Damage(attack);
                        Console.WriteLine($"{playerName} took {attack} damage!\n");
                        return;

                    // Enemy heals.
                    case 2:
                        Console.WriteLine($"{_name} heals!");
                        int heal = Heal();
                        Console.WriteLine($"{_name} recovered {heal} health!\n");
                        return;
                }
            }
        }
    }
}