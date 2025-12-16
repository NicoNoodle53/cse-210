using System;
using System.Collections.Generic;
using System.Linq; // Required for Where(), Any(), and OrderBy()

public class War
{
    private void DisplayStatus(int turnCount, List<ArmyUnit> army1, List<ArmyUnit> army2)
    {
        Console.Clear();
        Console.WriteLine($"                  BATTLE ROUND {turnCount}                    ");
        
        // Use LINQ to count only living units
        int living1 = army1.Count(u => !u.IsDead);
        int living2 = army2.Count(u => !u.IsDead);
        
        Console.WriteLine($"| Army 1: {living1} units remaining | Army 2: {living2} units remaining |");
        Console.WriteLine("");

        // Display current unit status (Living units only, ordered by type)
        Console.WriteLine("\n--- Army 1 Units (Current Status) ---");
        var army1Living = army1.Where(u => !u.IsDead).OrderBy(u => u._type);
        if (army1Living.Any())
        {
            foreach (var unit in army1Living)
            {
                Console.WriteLine($"- {unit._name} ({unit._type}) | HP: {unit._hp}, DMG: {unit._dmg}");
            }
        }
        else { Console.WriteLine("All units defeated."); }

        Console.WriteLine("\n--- Army 2 Units (Current Status) ---");
        var army2Living = army2.Where(u => !u.IsDead).OrderBy(u => u._type);
        if (army2Living.Any())
        {
            foreach (var unit in army2Living)
            {
                Console.WriteLine($"- {unit._name} ({unit._type}) | HP: {unit._hp}, DMG: {unit._dmg}");
            }
        }
        else { Console.WriteLine("All units defeated."); }


        Console.WriteLine("COMBAT LOG ");
    }

    private void PerformTurn(int armyNumber, List<ArmyUnit> attackingArmy, List<ArmyUnit> defendingArmy)
    {
        Console.WriteLine($"BEGIN ARMY {armyNumber} TURN");
        
        var livingAttackers = attackingArmy.Where(u => !u.IsDead).ToList();
        
        var random = new Random();
        var shuffledAttackers = livingAttackers.OrderBy(u => random.Next()).ToList();
        
        foreach (var unit in shuffledAttackers)
        {
            unit.Damage(defendingArmy);
        }
    }

    private void CleanupArmy(List<ArmyUnit> army)
    {
        army.RemoveAll(unit => unit.IsDead);
    }
    
    public void StartWar(List<ArmyUnit> army1, List<ArmyUnit> army2)
    {
        int turnCount = 1;
        
        while (army1.Any(u => !u.IsDead) && army2.Any(u => !u.IsDead))
        {
            DisplayStatus(turnCount, army1, army2);

            PerformTurn(1, army1, army2);

            Console.WriteLine("\n[END TURN] Press any key to continue to the next action...");
            Console.ReadKey(true);
            
            if (!army2.Any(unit => !unit.IsDead)) break;
            DisplayStatus(turnCount, army1, army2);
            PerformTurn(2, army2, army1);
            Console.WriteLine("END ROUND Press any key to continue to the next round...");
            Console.ReadKey(true);
            
            CleanupArmy(army1); 
            CleanupArmy(army2);
            
            turnCount++;
        }
        
        Console.Clear();
        if (army1.Any(u => !u.IsDead))
        {
            Console.WriteLine("ARMY 1 WINS THE WAR! ");
        }
        else if (army2.Any(u => !u.IsDead))
        {
            Console.WriteLine("ARMY 2 WINS THE WAR!");
        }
        else
        {
             Console.WriteLine("BOTH ARMIES WERE WIPED OUT! (Draw)");
        }
        Console.WriteLine($"Total Rounds: {turnCount - 1}");
        Console.WriteLine("");
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey(true);
    }
}