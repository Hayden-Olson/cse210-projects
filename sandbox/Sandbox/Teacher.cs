public class Teacher : Staff
{
    private int _roomNum;

    public Teacher(string firstname, string lastname, string gender, int roomnumber) : base(firstname, lastname, gender)
    {
        _roomNum = roomnumber;
    }

    public string Display()
    {
        return $"{_gender} {_lastName} from room {_roomNum}";
    }
}