public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 45, Status.FINE, new Weapon("club", 1, 13, 0, 5))
    {
   
    }

    public override int EnemyTurn()
    {
        if (_health > 0)
        {
            bool paralyzed = IsParalyzed();
            if (paralyzed == false)
            {
                Console.WriteLine($"{_name} attacks!");
                int attack = _weapon.GetDamage(this);
                return attack;
            }
            return 0;
        }
        Console.WriteLine($"The {_name} has been slain!");
        return 0;
    }
}