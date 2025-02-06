using System;
using System.Runtime.Serialization;

class Program2
{
    static void Main(string[] args)
    {
        Person p1 = new Person();

        // Private variables can only change within the class, 
        // so we need methods to feed in changes.
        p1.SetName("Jerry");
        p1.SetAge(23);

        // This only works with public class variables.
        //p1._name = "Jerry";
        //p1._age = 23;

        p1.Display();

        string theName = p1.GetName();
        Console.WriteLine($"The person's name was: {theName}");
    }
}