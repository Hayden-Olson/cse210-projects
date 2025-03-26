public class Character
{
    // This is the parent class to Player and Enemy. It obtains the information both classes need.
    protected int _health;
    protected Status _status;
    protected string _name;
    protected Weapon _weapon;

    public Character(string name, int health, Status status, Weapon weapon)
    {
       
    }

    public Status GetStatus()
    {
        return _status;
    }

    public int GetHealth()
    {
        return _health;
    }

    public int RandomNumber(int number)
    {
        Random random = new Random();
        return number;
    }
}