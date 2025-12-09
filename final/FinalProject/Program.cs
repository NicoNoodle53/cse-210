using System;

class Program
{
   static void Main(string[] args)
    {
        int option = 0;
        while (option != 6)
        {
            Console.WriteLine("Choose from the options below by typing in number you wish to select");
            Console.WriteLine("1: Add units to army 1");
            Console.WriteLine("2: Add units to army 2");
            Console.WriteLine("3: Display units in army 1");
            Console.WriteLine("4: Display units in army 2");
            Console.WriteLine("5: Start the war");
            Console.WriteLine("6: Quit program");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                //add units to army 1
            }
            if (option == 2)
            {
                //add units to army 2
            }
            if (option == 3)
            {
                //display units in army 1
            }
            if (option == 4)
            {
                //display units in army 2
            }
            if (option == 5)
            {
                //initiate war
            }

        }
    }
}