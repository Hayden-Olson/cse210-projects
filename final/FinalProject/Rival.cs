public class Rival : Enemy
{
    public Rival() : base("Rival", 150, Status.FINE, new Weapon("sword", 10, 30, 2, 16))
    {
   
    }

    public override void EnemyTurn()
    {

    }
}