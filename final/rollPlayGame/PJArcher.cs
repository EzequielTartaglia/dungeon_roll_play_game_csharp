using System;
using System.Text;

public class PJArcher : BasePlayerCharacter
{
    // Properties for the archer
    public string SpecialMoveTitle { get; set; }
    public int SpecialMoveDamage { get; set; }

    // Constructors
    public PJArcher(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle = "", int specialMoveDamage = 0)
        : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPotions, level, physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = specialMoveDamage;
    }

    // Get all stats
    public override string GetAllStats()
    {
        var stats = new StringBuilder();
        stats.AppendLine("Dungeon of the Underworld\n");
        stats.AppendLine($"Life: {GetlifePoints()}");
        stats.AppendLine($"Mana: {GetManaPoints()}");
        stats.AppendLine($"Level: {GetLevel()}");
        stats.AppendLine($"Physical Damage: {GetPhysicalDamage()}");
        stats.AppendLine($"Magic Damage: {GetMagicDamage()}");
        stats.AppendLine($"Attack Speed: {GetAttackSpeed()}");
        stats.AppendLine($"Celerity: {GetCelerity()}");
        stats.AppendLine($"Special Move: ['{GetSpecialMoveTitle()}' : {GetSpecialMoveDamage()} damage]");

        return stats.ToString();
    }

    // Upgrade skills
    public override int UpgradeSkills(int pointsToAssign)
    {
        Console.Clear();
        _pointsToAssign = pointsToAssign;

        if (_pointsToAssign <= 0)
        {
            Console.WriteLine("No points to assign.");
            return _pointsToAssign;
        }

        Console.WriteLine("Dungeon of the Underworld\n");
        Console.WriteLine("Select a skill to upgrade:\n");
        Console.WriteLine("[1] Life Points\n[2] Mana Points\n[3] Physical Damage\n[4] Magic Damage\n[5] Attack Speed\n[6] Celerity\n[7] Special Skill\n[8] Back to Menu");
        Console.Write("\nYour choice: ");

        if (!int.TryParse(Console.ReadLine(), out int skillToUpgrade) || skillToUpgrade < 1 || skillToUpgrade > 8)
        {
            Console.WriteLine("Invalid option. Try again.");
            return _pointsToAssign;
        }

        if (skillToUpgrade == 8) return _pointsToAssign; 

        int increaseValue = skillToUpgrade <= 2 ? 50 : (skillToUpgrade == 7 ? 20 : 5);

        switch (skillToUpgrade)
        {
            case 1: SetlifePoints(GetlifePoints() + increaseValue); break;
            case 2: SetManaPoints(GetManaPoints() + increaseValue); break;
            case 3: SetPhysicalDamage(GetPhysicalDamage() + increaseValue); break;
            case 4: SetMagicDamage(GetMagicDamage() + increaseValue); break;
            case 5: SetAttackSpeed(GetAttackSpeed() + increaseValue); break;
            case 6: SetCelerity(GetCelerity() + increaseValue); break;
            case 7: SetSpecialMoveDamage(GetSpecialMoveDamage() + increaseValue); break;
        }

        _pointsToAssign--;
        SetPointsToAssign(_pointsToAssign);

        return _pointsToAssign;
    }
}
