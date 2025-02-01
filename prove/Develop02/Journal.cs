using System.IO;
public class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void RemoveEntry()
    {
        Console.Write("Which entry slot do you wish to remove? (Put index number.) ");
        string eliminate = Console.ReadLine();
        
        _entries.RemoveAt(int.Parse(eliminate));
    }

    public void SaveToFile()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.Write(entry.GetCsvVersion());
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Which file name? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);
        
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');

            string date = parts[0];
            string question = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._question = question;
            entry._response = response;

            _entries.Add(entry);
        }
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();  
        }
    }
}