using System;
using System.Collections.Generic; 

public class CreateArmy
{

    public List<ArmyUnit> _army = new List<ArmyUnit>();

    private void AddUnitByType(int option)
    {
        ArmyUnit newUnit = null;

        switch (option)
        {
            case 1:
                newUnit = new Archer();
                break;
            case 2:
                newUnit = new Assasin();
                break;
            case 3:
                newUnit = new Defender();
                break;
            case 4:
                newUnit = new Knight();
                break;
            case 5:
                newUnit = new Mage();
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                return; 
        }

        if (newUnit != null)
        {
            _army.Add(newUnit);
        }
    }
public void AddUnits()
    {
        int option = 0;
        while (option != 6)
        {
            Console.Clear();
            
            Console.WriteLine("\n--- Add Units ---");
            Console.WriteLine("Pick what type of unit you wish to add:");
            Console.WriteLine("1: Archer");
            Console.WriteLine("2: Assasin");
            Console.WriteLine("3: Defender");
            Console.WriteLine("4: Knight");
            Console.WriteLine("5: Mage");
            Console.WriteLine("6: Exit");
            Console.Write("Enter selection: ");
            
            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option >= 1 && option <= 5)
                {
                    AddUnitByType(option);
                    Console.WriteLine("Press Enter to add another unit...");
                    Console.ReadLine();
                }
                else if (option == 6)
                {
                    Console.WriteLine("Returning to main menu.");
                }
                else
                {
                    Console.WriteLine("Invalid option. Enter a number between 1 and 6.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                option = 0; 
            }
        }
    }
}