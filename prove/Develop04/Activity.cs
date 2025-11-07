using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _time;
    public Activity()
    {

    }
    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }
    public void Loading()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
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
            currentTime = DateTime.Now;
        }
    }
    public void Ready()
    {
        Console.WriteLine("Get ready ...");
        Loading();
    }
    public void Intro()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _time = int.Parse(Console.ReadLine());
    }
    public void Exit()
    {
        Console.WriteLine("Good job!");
        Loading();
        Console.WriteLine($"You have completed {_time} seconds of the {_name}");
        Loading();
    }
}