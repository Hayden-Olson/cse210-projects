public class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\n")
    {

    }

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count;

    
    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(0, _prompts.Count())];

        Console.WriteLine($"--{prompt}--");
    }

    public void Run()
    {
        int pace = ShowIntro();
        
       
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        DateTime _futureTime = DateTime.Now.AddSeconds(pace);
        int count = 0;
        Console.WriteLine("");

        while (DateTime.Now < _futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        // This ShowEnding has a special message attached in the final parameter.
        ShowEnding(pace, $"You listed {count} responses!");
    }
}