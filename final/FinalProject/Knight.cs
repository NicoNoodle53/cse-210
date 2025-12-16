using System;

public class Knight : ArmyUnit
{
    List<string> _names = new List<string>
    {
        "Sir Kaelen Valor", "Lady Elara Steadfast", "Lord Gideon Plate", "Seraphina Oath", "Dorian Lightbrand", "Valeria Crest", "Torvin Lionheart",
         "Briar Lance", "Corbin Sentinel", "Rhea Argent", "Marcus Paladin", "Astrid Fane", "Oric Gryphon", "Jessa Steel", "Ragnar Helm", "Isolde Shield", 
         "Thane Sovereign", "Lira Wyvern", "Arden Swiftblade", "Zane Trueborn"
    };

    public Knight()
    {
        _dmg = 5;
        _hp = 40;
        _type = "Knight";
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
        ArmyUnit target = FindTarget(enemyArmy, priority);

        if (target != null)
        {
            target.TakeDamage(damageDealt);
            
            Console.WriteLine(
                $"{_name} ({_type}) attacks {target._name} ({target._type}), dealing {damageDealt} damage. " +
                $"{target._name}'s HP: {target._hp}"
            );

        }
        else
        {
            Console.WriteLine($"{_name} ({_type}) finds no suitable targets to attack.");
        }
    }
}
