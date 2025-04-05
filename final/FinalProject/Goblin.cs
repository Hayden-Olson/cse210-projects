public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 45, Status.FINE, new Weapon("club", 1, 13, 0, 5))
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
                // Enemy does a normal attack.
                Console.WriteLine($"{_name} attacks!");
                int attack = _weapon.GetDamage(this);
                player.Damage(attack);
                Console.WriteLine($"{playerName} took {attack} damage!\n");
            }
        }
    }
}