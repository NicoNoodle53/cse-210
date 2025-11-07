using System;
public class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string _prompt;
    public ReflectionActivity() : base()
    {
        _name = "Reflection activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompt = GetRandomPrompt();
    }
    private string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumb = randomGenerator.Next(0, 3);
        string prompt = _prompts[randomNumb];
        return prompt;
    }
    private string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomNumb = randomGenerator.Next(0, 8);
        string question = _questions[randomNumb];
        return question;
    }

    public void Reflection()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        DateTime currentTime = DateTime.Now;
        Console.WriteLine(_prompt);
        Loading(2);
        Console.WriteLine();
        while (currentTime < futureTime)
        {
            TimeSpan timeLeft = futureTime - DateTime.Now;
            if (timeLeft.TotalSeconds > 5)
            {
                Console.WriteLine(GetRandomQuestion());
                Loading(5);
                Console.WriteLine();
            }
            else if (timeLeft.TotalSeconds < 5)
            {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("/");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("-");
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Write("\\");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            currentTime = DateTime.Now;
        }

    }
}