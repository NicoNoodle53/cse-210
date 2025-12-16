using System;
using System.Linq;

class Program
{
    static CreateArmy army1Manager = new CreateArmy();
    static CreateArmy army2Manager = new CreateArmy();

    static War warSimulator = new War();

    static void Main(string[] args)
    {
        int option = 0;
        while (option != 6)
        {
            Console.Clear(); 
            
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("Choose from the options below by typing in number you wish to select");
            Console.WriteLine("1: Add units to army 1");
            Console.WriteLine("2: Add units to army 2");
            Console.WriteLine("3: Display units in army 1");
            Console.WriteLine("4: Display units in army 2");
            Console.WriteLine("5: Start the war");
            Console.WriteLine("6: Quit program");
            
            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1)
                {
                    army1Manager.AddUnits();
                }
                else if (option == 2)
                {
                    army2Manager.AddUnits();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    DisplayArmy(1, army1Manager._army);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    DisplayArmy(2, army2Manager._army);
                }
                else if (option == 5)
                {
                    warSimulator.StartWar(army1Manager._army, army2Manager._army);
                }
                else if (option == 6)
                {
                    Console.WriteLine("Program quitting.");
                }
                else
                {
                    Console.WriteLine("Invalid option selected. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    
        static void DisplayArmy(int armyNumber, List<ArmyUnit> army)
        {
            Console.WriteLine($"\n--- Army {armyNumber} ({army.Count} Units) ---");
            if (army.Count == 0)
            {
                Console.WriteLine("Army is empty.");
            }
            else
            {
                foreach (var unit in army)
                {
                    Console.WriteLine($"- {unit._name} ({unit._type})");
                }
            }
        
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey(true);
        }
    }
