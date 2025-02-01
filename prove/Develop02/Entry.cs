public class Entry
{
    public string _question;
    public string _date;
    public string _author;
    public string _response;

    public void GetFromUser()
    {
        _question = PromptGenerator.GetPrompt();
        Console.WriteLine(_question);
        Console.Write("> ");

        _response = Console.ReadLine();

        _date = DateTime.Now.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} - Prompt: {_question}\n{_response}");
        Console.WriteLine();
    }
    
    public string GetCsvVersion()
    {
        return $"{_date}~{_question}~{_response}";
    }
}