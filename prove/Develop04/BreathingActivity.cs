public class BreathingActivity : Activity
{
    private string _name = "Breathing Activity";

    public void Run()
    {
        ShowIntro(_name);
        Console.WriteLine("You should prepare yourself before we begin.");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine("");
        int pace = GetTime();
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        ShowSpinner();
        DateTime _futureTime = DateTime.Now.AddSeconds(pace);

        while (DateTime.Now < _futureTime)
        {
            
            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountdown(4);
            Console.WriteLine("");
            Console.Write("Breath out...");
            ShowCountdown(6);
            Console.WriteLine("");
        
        }
        ShowEnding(_name, pace);
    }
}