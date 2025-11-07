using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice !=4)
        {
            Console.WriteLine("MenueOptions:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Intro();
                activity.Ready();
                activity.Breathing();
                activity.Exit();
            }

            if (choice == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Intro();
                activity.Ready();
                activity.Reflection();
                activity.Exit();

            }
            
            if(choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Intro();
                activity.Ready();
                activity.listing();
                activity.Exit();
            }
        }
    }
}