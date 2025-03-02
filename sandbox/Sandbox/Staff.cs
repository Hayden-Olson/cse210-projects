public class Staff
{
    protected string _firstName;
    protected string _lastName;
    protected string _gender;

    public Staff(string firstname, string lastname, string gender)
    {
        _firstName = firstname;
        _lastName = lastname;
        _gender = gender;

        if (_gender == "male")
            _gender = "Mr.";
        else if (_gender == "female")
            _gender = "Ms";
    }

}