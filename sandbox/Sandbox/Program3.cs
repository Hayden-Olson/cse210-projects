class Program3
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Jurassic Park", "Michael Crichton");
        Book b2 = new Book("Tom Sawyer", "Mark Twain");

        b1.CheckOut();

        Library theLibrary = new Library();
        theLibrary.AddBook(b1);
        theLibrary.AddBook(b2);

        theLibrary.DisplayCatalog();
    }
}