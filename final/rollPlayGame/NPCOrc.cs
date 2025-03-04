using System;

public class NPCOrc : BaseNPCharacter
{
    // Additional properties specific to NPCOrc
    public string SpecialMoveTitle { get; private set; }
    public int SpecialMoveDamage { get; private set; }

    // Default constructor
    public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
        : this(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, "", 0) { }

    // Constructor with special move title
    public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle)
        : this(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, specialMoveTitle, 0) { }

    // Full constructor
    public NPCOrc(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle, int specialMoveDamage)
        : base(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity)
    {
        SpecialMoveTitle = specialMoveTitle;
        SpecialMoveDamage = specialMoveDamage;
    }
}
