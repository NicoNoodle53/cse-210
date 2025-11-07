using System;

public class ListingActivity : Activity
{
    private List<string> _answers = new List<string>();
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base()
    {
        _name = "Listing activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumb = randomGenerator.Next(0, 4);
        string prompt = _prompts[randomNumb];
        return prompt;
    }
    public void listing()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("You may begin in");
        for (int count = 5; count > 0; count--)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            _answers.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_answers.Count} items!");
        Console.WriteLine();
    }
}