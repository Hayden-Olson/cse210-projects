public class BreathingActivity : Activity
{

    public BreathingActivity() : base("Breathing Activity","\n\nYou should prepare yourself before we begin.\n\nThis activity will help you relax by walking you through breathing in and out slowly.\n\nClear your mind and focus on your breathing.\n\n")
    {

    }

    public void Run()
    {
        int pace = ShowIntro();
        
       
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
        ShowEnding(pace);
    }
}