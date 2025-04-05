public class Demon : Enemy
{
    // This enemy may be the only time you may want to use quake.
    public Demon() : base("Demon",200,Status.FINE, new Weapon("katana", 15, 40, 7, 21), 0)
    {
      
    }
}