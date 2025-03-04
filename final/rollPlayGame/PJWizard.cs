using System;

public class PJWizard : BasePlayerCharacter
{
    // Properties for the wizard
    public string SpecialMoveTitle { get; set; }
    public int SpecialMoveDamage { get; set; }

    // Constructors
    public PJWizard(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, 
                    int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, 
                    int pointsToAssign, string specialMoveTitle = "", int specialMoveDamage = 0) 
                    : base(lifePoints, manaPoints, experiencePoints, healPotions, manaPotions, level, 
                           physicalDamage, magicDamage, attackSpeed, celerity, pointsToAssign)
    {
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = specialMoveDamage;
    }
    
    // Method to get all stats
    public override string GetAllStats()
    {
        return $@"
        Dungeon of the underworld

        Life: {GetlifePoints()}
        Mana: {GetManaPoints()}
        Lvl: {GetLevel()}
        Physical Damage: {GetPhysicalDamage()}
        Magical Damage: {GetMagicDamage()}
        Attack Speed: {GetAttackSpeed()}
        Celerity: {GetCelerity()}
        Special move: ['{GetSpecialMoveTitle()}' : {GetSpecialMoveDamage()} damage]";
            }

    public override int UpgradeSkills(int pointsToAssign)
    {
        Console.Clear();
        _pointsToAssign = pointsToAssign;

        if (_pointsToAssign <= 0)
        {
            Console.WriteLine("No points to assign");
            return _pointsToAssign;
        }

        Console.WriteLine("Dungeon of the underworld\n");
        Console.WriteLine("Write the number of the skill to upgrade.\n");
        Console.WriteLine("[1] Life points");
        Console.WriteLine("[2] Mana points");
        Console.WriteLine("[3] Physical damage");
        Console.WriteLine("[4] Magic damage");
        Console.WriteLine("[5] Attack speed");
        Console.WriteLine("[6] Celerity");
        Console.WriteLine("[7] Special skill");
        Console.WriteLine("[8] Back menu\n");

        int skillToUpgrade;
        while (!int.TryParse(Console.ReadLine(), out skillToUpgrade) || skillToUpgrade < 1 || skillToUpgrade > 8)
        {
            Console.WriteLine("Invalid option, try again");
            Console.Write("Select a choice from the menu: ");
        }

        // Directly updating stats
        switch (skillToUpgrade)
        {
            case 1: SetlifePoints(GetlifePoints() + 50); break;
            case 2: SetManaPoints(GetManaPoints() + 50); break;
            case 3: SetPhysicalDamage(GetPhysicalDamage() + 5); break;
            case 4: SetMagicDamage(GetMagicDamage() + 5); break;
            case 5: SetAttackSpeed(GetAttackSpeed() + 5); break;
            case 6: SetCelerity(GetCelerity() + 5); break;
            case 7: SetSpecialMoveDamage(GetSpecialMoveDamage() + 20); break;
            case 8: return _pointsToAssign; // Exit the menu without upgrading
        }

        _pointsToAssign--;
        SetPointsToAssign(_pointsToAssign);
        return _pointsToAssign;
    }
}
