using System;

public class Player : Character
{
    // This is the class that stores the information for the users character.
    private ListName _playerHealth;
    private Weapon _playerWeapon;
    private string _playerName;

    public Player(string name, int health, Status status, Weapon weapon) : base(health, status, weapon)
    {
        _playerName = name;
       
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    public int GetPlayerHealth()
    {
         _playerHealth = GetHealth();
        return _playerHealth;
    }
}