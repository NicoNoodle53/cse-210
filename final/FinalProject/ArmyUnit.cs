using System;

public class ArmyUnit
{
    public string _name;
    public int _dmg;
    public int _hp;
    public string _type;
    public bool IsDead = false;
    protected static Random randomGenerator = new Random();

    public ArmyUnit()
    {
        
    }

    public virtual int TakeDamage(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            UnitDeath();
        }
        return damage;
    }
    protected void UnitDeath()
    {
        {
        if (!IsDead)
        {
            IsDead = true;
            Console.WriteLine($"{_name} ({_type}) has been defeated!");
        }
    }
    }
    public virtual void Damage(List<ArmyUnit> enemyArmy)
    {
        
    }
    protected string RandomName(List<string> names)
    {
        int randomNumb = randomGenerator.Next(0, 19);
        string newName = names[randomNumb];
        return newName;
    }

    protected ArmyUnit FindTarget(List<ArmyUnit> enemyArmy, params string[] priorityTypes)
    {
    foreach (string type in priorityTypes) 
    {
        List<ArmyUnit> potentialTargets = enemyArmy
            .Where(u => u._type == type && !u.IsDead)
            .ToList(); 

        if (potentialTargets.Count > 0)
        {
            int randomIndex = randomGenerator.Next(0, potentialTargets.Count);
            return potentialTargets[randomIndex]; 
        }
    }
    return null; 
    }     
}