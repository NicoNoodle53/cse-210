using System;

public class Defender : ArmyUnit
{
    List<string> _names = new List<string>
    {
        "Borin Ironclad", "Vala Stonewall", "Gareth Shieldbreak", "Rhea Bastion", "Torvald Boulderhand", "Lyra Aegis", "Kaelen Rampart", "Draven Guard", "Anika Bulwark", 
        "Milo Fortis", "Jax Titan", "Sasha Keeper", "Ragnar Helm", "Elara Warden", "Gideon Holdfast", "Breton Block", "Ulfric Hilt", "Zena Rampart", "Corbin Sentinel", 
        "Tyrus Barricade"
    };

    public Defender()
    {
        _dmg = 0;
        _hp = 60;
        _type = "Defender";
        _name = RandomName(_names);
    }
    override public int TakeDamage(int damage)
    {
        if (randomGenerator.Next(1, 101) <= 10) 
        {
            Console.WriteLine($"BLOCK! {_name} ({_type}) successfully blocked the attack!");
            return 0; 
        }

        int damageTaken = base.TakeDamage(damage);
        
        return damageTaken;
    }
}