using System;
using System.Security.Cryptography.X509Certificates;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }
}