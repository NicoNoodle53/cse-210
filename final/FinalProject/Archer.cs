using System;

public class Archer : ArmyUnit
{
    List<string> _names = new List<string>
    {
        "Silas Swiftbow", "Lyra Windwhisper", "Aeron Hawkstrike", "Elara Arroway", "Fennel Trueflight", "Rylan Shade", "Mira Longshot", "Kaelen Quiver", 
        "Jessa Fletch", "Torvin Greenleaf", "Zephyr Bolt", "Seraphine Thistle", "Darian Vane", "Nyssa Glade", "Corbin Wayfarer", "Briar Notch", 
        "Valen Strider", "Isolde Keeneye", "Orin Foresthand", "Roric Featherfall"
    };

    public Archer()
    {
        _dmg = 10;
        _hp = 30;
        _type = "Archer";
        _name = RandomName(_names);
    }

    override public void Damage(List<ArmyUnit> enemyArmy)
    {
        int damageDealt = _dmg;
        bool isCritical = false;

        if (_hp <= 0)
        {
            return;
        }
        
        if (randomGenerator.Next(1, 101) <= 10) 
        {
            damageDealt *= 2;
            isCritical = true;
        }

        string[] priority = { "Defender", "Knight", "Assasin", "Archer", "Mage" };
        ArmyUnit target = FindTarget(enemyArmy, priority);

        if (target != null)
        {
            target.TakeDamage(damageDealt);
            
            string critMessage = isCritical ? "CRITICAL HIT!" : "";
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