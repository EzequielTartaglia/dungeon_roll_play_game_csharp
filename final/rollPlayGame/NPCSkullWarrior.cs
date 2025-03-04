using System;

public class NPCSkull : BaseNPCharacter
{
    // Additional properties specific to NPCSkull
    public string SpecialMoveTitle { get; private set; }
    public int SpecialMoveDamage { get; private set; }

    // Default constructor
    public NPCSkull(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
        : this(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, "", 0) { }

    // Constructor with special move title
    public NPCSkull(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle)
        : this(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity, specialMoveTitle, 0) { }

    // Full constructor
    public NPCSkull(int lifePoints, int manaPoints, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, string specialMoveTitle, int specialMoveDamage)
        : base(lifePoints, manaPoints, level, physicalDamage, magicDamage, attackSpeed, celerity)
    {
        SpecialMoveTitle = specialMoveTitle;
        SpecialMoveDamage = specialMoveDamage;
    }
}
