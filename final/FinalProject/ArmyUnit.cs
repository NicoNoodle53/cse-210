using System;

public class ArmyUnit
{
    protected string _name;
    protected int _dmg;
    protected int _hp;

    public ArmyUnit()
    {
        
    }

    protected int TakeDamage(int damage)
    {
        return damage;
    }
    protected void UnitDeath()
    {
        
    }
    public virtual void Damage()
    {
        
    }
        
}