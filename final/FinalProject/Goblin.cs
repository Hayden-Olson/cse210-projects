public class Goblin : Enemy
{
    public Goblin() : base("Goblin", 45, Status.FINE, new Weapon("club", 1, 13, 0, 5))
    {
   
    }

    public override void EnemyTurn()
    {

    }
}