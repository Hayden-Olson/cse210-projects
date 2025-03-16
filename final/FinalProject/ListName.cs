public class ListName
{
    // This class stores all information for names and numbers associated to characters.The goal is to have the Character class obtain this information and then share it with the classes that call it.
    private static List<string>_enemyName = new List<string>();
    private static List<string>_weaponName = new List<string>();
    private static List<int>_healthAmount = new List<int>();


    public static void EnemyNames()
    {
        _enemyName.Add("Goblin");
        _enemyName.Add("Brute");
        _enemyName.Add("Rival");
        _enemyName.Add("Demon");
    }

    public static void WeaponNames()
    {
        _weaponName.Add("sword");
        _weaponName.Add("club");
        _weaponName.Add("knife");
        _weaponName.Add("katana");
    }

    public static void HealthAmount()
    {
        _healthAmount.Add(150);
        _healthAmount.Add(45);
        _healthAmount.Add(75);
        _healthAmount.Add(200);
    }

    public static string GetEnemyName(int index)
    {
        return _enemyName[index];
    }

    public static string GetWeaponName(int index)
    {
        return _weaponName[index];
    }

    public static int GetHealthAmount(int index)
    {
        return _healthAmount[index];
    }
}