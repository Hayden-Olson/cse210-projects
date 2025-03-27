public class Character
{
    // This is the parent class to Player and Enemy. It obtains the information both classes need.
    protected int _health;
    protected Status _status;
    protected string _name;
    protected Weapon _weapon;
    protected int _statusCount;

    public Character(string name, int health, Status status, Weapon weapon)
    {
       _statusCount = 0;
    }

    public string GetName()
    {
        Console.WriteLine("What is your name hero? ");
        string name = Console.ReadLine();
        return name;
    }

    public Status GetStatus()
    {
        return _status;
    }

    public int GetHealth()
    {
        return _health;
    }

    // Paralyzed characters will have a 50/50 chance to get a turn.
    public bool IsParalyzed()
    {
        if (_status == Status.PARALYZED)
            {
                int paralyzed_check = new Random().Next(1,3);
                if (paralyzed_check == 1)
                {
                    Console.WriteLine($"{_name} could not move!");
                    return true;
                }
            }
        return false;
    }

    // Burned characters will take random damage after their action.
    public void IsBurned()
    {
        int additionalDamage = new Random().Next(15,31);
        _health -= additionalDamage;
        Console.WriteLine($"{_name} took burning damage!");
    }

    // After 3 turns, status effects are removed.
    public void FeelingBetter()
    {
        if (_statusCount > 3)
        {
            _statusCount += 1;
        }

        else
        {
            _status = Status.FINE;
            _statusCount = 0;
        }
    }

    // Character will regain health.
    public void Heal()
    {
        int heal = new Random().Next(1,50);
        _health += heal;
    }

    public void MagicCast(string spell)
    {
        if (spell == "fire")
        {
            _status = Status.BURNED;
        }

        if (spell == "shock")
        {
            _status = Status.PARALYZED;
        }

        if (spell == "quake")
        {
            _status = Status.WEAK;
        }
    }
}