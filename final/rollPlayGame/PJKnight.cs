using System;

public class PJKnight : BasePlayerCharacter 
{
    // Properties for the knight
    public string SpecialMoveTitle { get; set; }
    public int SpecialMoveDamage { get; set; }

    // Constructors - Default values handled via base class
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, 
                    int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign) 
        : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPotions, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        SpecialMoveTitle = "";
        SpecialMoveDamage = 0;
    }

    // Constructor with special move title
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, 
                    int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle) 
        : this(lifePoints, manaPoints, experiencePoints, healPotions, manaPotions, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        SpecialMoveTitle = specialMoveTitle;
    }

    // Constructor with special move title and damage
    public PJKnight(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, 
                    int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle, int specialMoveDamage) 
        : this(lifePoints, manaPoints, experiencePoints, healPotions, manaPotions, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign, specialMoveTitle)
    {
        SpecialMoveDamage = specialMoveDamage;
    }

    // Method to get all stats
    public override string GetAllStats()
    {
        return $@"
        Dungeon of the underworld

        Life: {GetlifePoints()}
        Mana: {GetManaPoints()}
        Level: {GetLevel()}
        Physical Damage: {GetPhysicalDamage()}
        Magic Damage: {GetMagicDamage()}
        Attack Speed: {GetAttackSpeed()}
        Celerity: {GetCelerity()}
        Special Move: ['{SpecialMoveTitle}' : {SpecialMoveDamage} damage]
        ";
    }

    // Method to upgrade the skills
    public override int UpgradeSkills(int pointsToAssign)
    {
        Console.Clear();
        this._pointsToAssign = pointsToAssign;

        if (_pointsToAssign <= 0)
        {
            Console.WriteLine("No points to assign");
            return _pointsToAssign;
        }

        Console.WriteLine("Dungeon of the underworld\n");
        Console.WriteLine("Select the skill to upgrade:\n");
        Console.WriteLine("[1] Life points");
        Console.WriteLine("[2] Mana points");
        Console.WriteLine("[3] Physical damage");
        Console.WriteLine("[4] Magic damage");
        Console.WriteLine("[5] Attack speed");
        Console.WriteLine("[6] Celerity");
        Console.WriteLine("[7] Special skill");
        Console.WriteLine("[8] Back menu");
        Console.Write("Select a choice from the menu: ");
        
        int skillToUpgrade;
        while (!int.TryParse(Console.ReadLine(), out skillToUpgrade) || skillToUpgrade < 1 || skillToUpgrade > 8)
        {
            Console.WriteLine("Invalid option, try again.");
            Console.Write("Select a choice from the menu: ");
        }

        if (skillToUpgrade == 8) return _pointsToAssign;

        // Handle skill upgrades and reduce points to assign
        UpgradeSkill(skillToUpgrade);
        _pointsToAssign--;
        SetPointsToAssign(_pointsToAssign);

        return _pointsToAssign;
    }

    // Handle the upgrade logic based on selected skill
    private void UpgradeSkill(int skillToUpgrade)
    {
        switch (skillToUpgrade)
        {
            case 1: SetlifePoints(GetlifePoints() + 50); break;
            case 2: SetManaPoints(GetManaPoints() + 50); break;
            case 3: SetPhysicalDamage(GetPhysicalDamage() + 5); break;
            case 4: SetMagicDamage(GetMagicDamage() + 5); break;
            case 5: SetAttackSpeed(GetAttackSpeed() + 5); break;
            case 6: SetCelerity(GetCelerity() + 5); break;
            case 7: SetSpecialMoveDamage(GetSpecialMoveDamage() + 20); break;
        }
    }
}
