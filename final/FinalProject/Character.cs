public class Character
{
    // This is the parent class to Player and Enemy. It obtains the information both classes need.
    protected int _health;
    protected Status _status;
    protected string _name;
    protected Weapon _weapon;
    protected int _statusCount;
    protected int _maxHealth;

    public Character(string name, int health, Status status, Weapon weapon, int statusCount)
    {
       _statusCount = statusCount;
       _name = name;
       _health = health;
       _status = status;
       _weapon = weapon;
       _maxHealth = _health;
    }

    // Player will use this once. Player gives them a name.
    public static string SetName()
    {
        Console.Write("Hello adventurer! What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("");
        return name;
    }

    // Returns the Characters status.
    public Status GetStatus()
    {
        return _status;
    }

    // Used when Enemy or Player cast magic on each other. Sets the other's status to what they chose, resets their status counter, and overwrites the previous status.
    public void SetStatus(Status status)
    {
        _status = status;
        _statusCount = 0;
    }

    // Returns health of Character.
    public int GetHealth()
    {
        return _health;
    }

    // Used in the Heal() method. Prevents over healing.
    private void SetHealth(int health)
    {
        _health = health;
    }

    // Health of Character hit is reduced here.
    public int Damage(int damage)
    {
        _health -= damage;
        return _health;
    }

    // Retrieves the name of the Character.
    public string GetName()
    {
        return _name;
    }

    // Only Player really uses this. Used for damage formula in the Weapon class.
    public Weapon GetWeapon()
    {
        return _weapon;
    }

    // Paralyzed characters will have a 50/50 chance to get a turn.
    public bool IsParalyzed()
    {
        if (_status == Status.PARALYZED)
            {
                int paralyzed_check = new Random().Next(1,3);
                if (paralyzed_check == 1)
                {
                    Console.WriteLine($"{_name} could not move!\n");
                    return true;
                }
            }
        return false;
    }

    // Burned characters will take random damage after their action.
    public void IsBurned()
    {
        if (_status == Status.BURNED)
        {
            int additionalDamage = new Random().Next(15,31);
            _health -= additionalDamage;
            Console.WriteLine($"{_name} took {additionalDamage} burning damage!\n");
        }
    }

    // After 3 turns, status effects are removed.
    public void FeelingBetter()
    {
        if (_statusCount < 3)
        {
            _statusCount++;
        }

        else if (_statusCount >= 3 && _status != Status.FINE)
        {
            _status = Status.FINE;
            _statusCount = 0;
            Console.WriteLine($"{_name} is no longer afflicted!\n");
        }
    }

    // Character will regain health.
    public int Heal()
    {
        int heal = new Random().Next(1,50);
        _health += heal;

        if (_health >= _maxHealth)
        {
            SetHealth(_maxHealth);
            Console.WriteLine("Fully healed!");
        }
        return heal;
    }

    // Status of afflicted target is changed. I guess only Player needed this function as it exists for player's chosen inputs, but Enemy also uses this.
    public Status MagicCast(string spell)
    {
        Status status = Status.FINE;
        if (spell == "fire")
        {
            status = Status.BURNED;
        }

        if (spell == "shock")
        {
            status = Status.PARALYZED;
        }

        if (spell == "quake")
        {
            status = Status.WEAK;
        }
    return status;
    }
}