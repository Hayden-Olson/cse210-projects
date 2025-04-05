public class Doppleganger : Enemy
{
    // I wanted this class to inherit whatever name the player gave their character, but nothing I did worked.
    public Doppleganger() : base("Doppleganger", 150, Status.FINE, new Weapon("sword", 10, 30, 2, 16), 0)
    {
        
    }
}