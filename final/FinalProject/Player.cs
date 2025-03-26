using System;

public class Player : Character
{
    // This is the class that stores the information for the users character.
    private string _playerName;

    public Player(string name, int health, Status status, Weapon weapon) : base(name,150, Status.FINE, new Weapon("sword", 10, 30, 2, 16))
    {
        _playerName = name;
    }

  
}