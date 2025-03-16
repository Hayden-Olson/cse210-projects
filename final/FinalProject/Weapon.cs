public class Weapon
{
    // This class handles damage output based on the weapon name.
    private string _weaponName;
    private int _minDamage;
    private int _maxDamage;
    private int _minWeak;
    private int _maxWeak;


    public Weapon(string weapon, int min, int max, int minWeak, int maxWeak)
    {
        _weaponName = weapon;
        _minDamage = min;
        _maxDamage = max;
        _minWeak = minWeak;
        _maxWeak = maxWeak;
    }

    public string GetWeaponName()
    {
        return _weaponName;
    }

    public int GetDamage(Character character)
    {
        if (character.GetStatus() == Status.WEAK)
        {
            return new Random().Next(_minWeak, _maxWeak);
        }

        else
        {
            return new Random().Next(_minDamage, _maxDamage);
        }
    }
}