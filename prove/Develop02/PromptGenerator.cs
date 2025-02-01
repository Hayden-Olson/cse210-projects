public class PromptGenerator
{
    public static List<string>_prompts = new List<string>();

    public static void Init()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Consider and reflect on what might be your “favorite failure.”");
        _prompts.Add("Who is somebody that you miss? Why?");
        _prompts.Add("What do you need to give yourself more credit for?");
        _prompts.Add("What biases do you need to work on?");
        _prompts.Add("Who is the most difficult person in your life and why?");
    }
    public static string GetPrompt()
    {
        Random rand = new Random();
        int randomPrompt = rand.Next(0,10);
        return _prompts[randomPrompt];
    }
}