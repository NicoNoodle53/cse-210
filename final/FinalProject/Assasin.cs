using System;

public class Assasin : ArmyUnit
{
    List<string> _names = new List<string>
    {
        "Kai Shadowstep", "Rogue Whisper", "Zira Bladeheart", "Malachi Nightshade", "Sienna Venom", "Jaxon Silence", "Nyx Dagger", 
        "Orion Phantom", "Vesper Thorn", "Kaelen Shroud", "Drax Cutter", "Mina Wraith", "Caspian Mist", "Selene Gloom", "Thane Scythe",
        "Inara Dusk", "Corvus Zero", "Eliza Grime", "Rhys Sever", "Lira Smoke"
    };

    public Assasin()
    {
        _dmg = 10;
        _hp = 20;
        _type = "Assasin";
        _name = RandomName(_names);
    }
   override public void Damage(List<ArmyUnit> enemyArmy)
    {
        if (_hp <= 0)
        {
            Console.WriteLine($"{_name} ({_type}) is defeated and cannot attack.");
            return; 
        }
        
        int damageDealt = _dmg;
        bool isCritical = false;
        
        if (randomGenerator.Next(1, 101) <= 10) 
        {
            damageDealt *= 2;
            isCritical = true;
        }

        string[] priority = { "Archer", "Mage", "Assasin", "Knight", "Defender" };
        ArmyUnit target = FindTarget(enemyArmy, priority);

        if (target != null)
        {
            target.TakeDamage(damageDealt);
 
            string critMessage = isCritical ? " (CRITICAL HIT!)" : "";
            Console.WriteLine(
                $"{_name} ({_type}){critMessage} attacks {target._name} ({target._type}), dealing {damageDealt} damage. " +
                $"{target._name}'s HP: {target._hp}"
            );

        }
        else
        {
            Console.WriteLine($"{_name} ({_type}) finds no suitable targets to attack.");
        }
    }
}
