using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Breathing()
    {
        int intervals = _time / 10;
        int extraInterval = _time % 10;

        for (int i = 0; i < intervals; i++)
        {
            Console.WriteLine("Breath in ...");
            for (int count = 6; count > 0; count--)
            {
                Console.Write(count);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine("Breathe Out ...");
            for (int count = 4; count > 0; count--)
            {
                Console.Write(count);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
        if(extraInterval != 0)
        {
            if (extraInterval <= 5)
            {
                Console.WriteLine("Breath in ...");
                for (int count = extraInterval; count > 0; count--)
                {
                    Console.Write(count);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
            }
            if(extraInterval > 5)
            {
                Console.WriteLine("Breath in ...");
                for (int count = 5; count > 0; count--)
                {
                    Console.Write(count);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
                Console.WriteLine("Breathe Out ...");
                for (int count = extraInterval - 5; count > 0; count--)
                {
                    Console.Write(count);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine();
            }
        }
    }
}