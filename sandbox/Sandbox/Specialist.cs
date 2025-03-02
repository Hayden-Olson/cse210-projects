public class Specialist : Staff
{
    private string _specialty;

    public Specialist(string firstname, string lastname, string gender, string specialty) : base(firstname, lastname, gender)
    {
        _specialty = specialty;
    }

    public string Display()
    {
        return " ";
    }
}