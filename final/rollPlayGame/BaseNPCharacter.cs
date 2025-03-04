using System;

public abstract class BaseNPCharacter
{
    public int Life { get; protected set; } = 1;
    protected int Mana { get; set; } = 0;
    protected int Level { get; set; } = 1;
    public int PhysicalDamage { get; protected set; } = 0;
    public int MagicDamage { get; protected set; } = 0;
    public int AttackSpeed { get; protected set; } = 0;
    protected int Celerity { get; set; } = 0;
    protected string SpecialMoveTitle { get; set; } = string.Empty;
    public int SpecialMoveDamage { get; protected set; } = 0;

    public BaseNPCharacter(int life = 1, int mana = 0, int level = 1, int physicalDamage = 0, 
                           int magicDamage = 0, int attackSpeed = 0, int celerity = 0, 
                           string specialMoveTitle = "", int specialMoveDamage = 0)
    {
        Life = life;
        Mana = mana;
        Level = level;
        PhysicalDamage = physicalDamage;
        MagicDamage = magicDamage;
        AttackSpeed = attackSpeed;
        Celerity = celerity;
        SpecialMoveTitle = specialMoveTitle;
        SpecialMoveDamage = specialMoveDamage;
    }

    public void AttackPhysical(BaseNPCharacter target)
    {
        if (target == null) return;
        target.Life -= PhysicalDamage;
        Console.WriteLine($"Enemy attacks and inflicts {PhysicalDamage} points of physical damage.");
    }

    public void AttackMagic(BaseNPCharacter target)
    {
        if (Mana < 10)
        {
            Console.WriteLine("Enemy doesn't have enough mana. It loses its turn.");
            return;
        }

        if (target != null)
        {
            target.Life -= MagicDamage;
            Mana -= 10;
            Console.WriteLine($"Enemy attacks and inflicts {MagicDamage} points of magic damage.");
        }
    }

    public abstract void SpecialMove(BaseNPCharacter target);
}
