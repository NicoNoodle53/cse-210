using System;
using System.Linq;

public class Mage : ArmyUnit
{
    List<string> _names = new List<string>
    {
        "Elias Starfire", "Lyra Whisperwind", "Aerion Flux", "Vesper Rune", "Kaelen Eldritch", "Seraphina Prism", "Dorian Arcanum", "Anya Gloom", "Thane Wyrm",
         "Isolde Cinder", "Orin Hex", "Jessa Astral", "Corbin Lumina", "Rhea Glynn", "Milo Shadowmancer", "Zira Kelp", "Fenris Stormcall", "Elara Myst", "Rylan Zenith", 
         "Valen Scryer"
    };

    public Mage()
    {
        _dmg = 10;
        _hp = 20;
        _type = "Mage";
        _name = RandomName(_names);
    }
   override public void Damage(List<ArmyUnit> enemyArmy)
    {
        if (_hp <= 0 || IsDead)
        {
            Console.WriteLine($"{_name} ({_type}) is defeated and cannot attack.");
            return; 
        }
        
        int damageDealt = _dmg;
        
        string[] priority = { "Defender", "Knight", "Assasin", "Archer", "Mage" };
        ArmyUnit primaryTarget = FindTarget(enemyArmy, priority);

        if (primaryTarget != null)
        {
            primaryTarget.TakeDamage(damageDealt);
            
            Console.WriteLine(
                $"{_name} ({_type}) attacks {primaryTarget._name} ({primaryTarget._type}), dealing {damageDealt} damage. " +
                $"{primaryTarget._name}'s HP: {primaryTarget._hp}"
            );
            
            if (randomGenerator.Next(1, 101) <= 10)
            {
                int splashDamage = damageDealt / 2;
                
                List<ArmyUnit> potentialSplashTargets = enemyArmy
                    .Where(unit => !unit.IsDead && unit != primaryTarget)
                    .ToList();

                int splashCount = 0;
                
                for (int i = 0; i < 2; i++)
                {
                    if (potentialSplashTargets.Count == 0)
                    {
                        break; 
                    }

                    int randomIndex = randomGenerator.Next(0, potentialSplashTargets.Count);
                    ArmyUnit splashTarget = potentialSplashTargets[randomIndex];
                    
                    splashTarget.TakeDamage(splashDamage);
                    splashCount++;

                    Console.WriteLine(
                        $"    -> SPLASH: {splashTarget._name} ({splashTarget._type}) takes {splashDamage} splash damage. " +
                        $"{splashTarget._name}'s HP: {splashTarget._hp}"
                    );

                    potentialSplashTargets.RemoveAt(randomIndex);
                }
                
                if (splashCount > 0)
                {
                    Console.WriteLine($"[AOE] {_name}'s spell successfully splashed to {splashCount} additional targets!");
                }
            } 
        }
        else
        {
            Console.WriteLine($"{_name} ({_type}) finds no suitable targets to attack.");
        }
    }
}