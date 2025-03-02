using System;
using System.Numerics;

class Program
{
    // static void Main(string[] args)
    // {
    //     Movie favoriteMovie = new Movie();
    //     favoriteMovie._title = "Star Wars";
    //     favoriteMovie._year = 1977;
    //     favoriteMovie._runtime = 150;
    //     favoriteMovie._rating = "PG";

    //     Movie otherMovie = new Movie();
    //     otherMovie._title = "Avatar";
    //     otherMovie._year = 2009;
    //     otherMovie._rating = "PG-13";
    //     otherMovie._runtime = 162;

    //     favoriteMovie.Display();

    //     DisplayMovie(favoriteMovie);
    //     DisplayMovie(otherMovie);

    //     Console.WriteLine(favoriteMovie._title);
    // }

    // static void DisplayMovie(Movie aMovie)
    // {
    //     Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    // }






    // Person p1 = new Person();

    // // Private variables can only change within the class, 
    // // so we need methods to feed in changes.
    // p1.SetName("Jerry");
    // p1.SetAge(23);

    // // This only works with public class variables.
    // //p1._name = "Jerry";
    // //p1._age = 23;

    // p1.Display();

    // string theName = p1.GetName();
    // Console.WriteLine($"The person's name was: {theName}");





    // Book b1 = new Book("Jurassic Park", "Michael Crichton");
    // Book b2 = new Book("Tom Sawyer", "Mark Twain");

    // b1.CheckOut();

    // Library theLibrary = new Library();
    // theLibrary.AddBook(b1);
    // theLibrary.AddBook(b2);

    // theLibrary.DisplayCatalog();






    static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Henry", "Williams", "male", 105);
        Console.WriteLine(teacher.Display());
    }
}