public class Book
{
    private string _title;
    private string _author;
    private string _checkOutDate;

    // Constructor
    public Book(string newTitle, string newAuthor)
    {
        _title = newTitle;
        _author = newAuthor;
        _checkOutDate = "";
    }

    // Methods
    public void CheckOut()
    {
        _checkOutDate = DateTime.Now.ToString("MM/dd/yyyy");
    }

    public bool IsCheckedOut()
    {
        bool isCheckedOut;

        if (_checkOutDate == "")
        {
            isCheckedOut = false;
        }
        else
        {
            isCheckedOut = true;
        }

        return isCheckedOut;
    }

    public void Display()
    {
        if (IsCheckedOut())
        {
            Console.WriteLine($"{_title} by {_author} checked out: {_checkOutDate}");
        }
        else
        {
            Console.WriteLine($"{_title} by {_author}");
        }

    }
}