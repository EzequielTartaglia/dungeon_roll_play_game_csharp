using System;

class Program
{
    public void InitializeCharacter(Character character)
    {
        character.SetlifePoints(200);
        character.SetManaPoints(400);
        character.SetExperiencePoints(0);
        character.SetPointsToAssign(5);
        character.SetLevel(1);
        character.SetHealPotions(2);
        character.SetManaPotions(2);
        character.SetPhysicalDamage(10);
        character.SetMagicDamage(50);
        character.SetAttackSpeed(15);
        character.SetCelerity(30);
        character.SetSpecialMoveTitle("Ruler of the elements");
        character.SetSpecialMoveDamage(80);
    }

    public void ShowMenu(Character character)
    {
        int storyOptions = 0;
        while (storyOptions != 7)
        {
            Console.Clear();
            Console.WriteLine("Dungeon of the underworld");
            Console.WriteLine($"You have {character.GetExperiencePoints()} experience points.");
            Console.WriteLine($"You have {character.GetPointsToAssign()} points to assign.");
            Console.WriteLine();
            Console.WriteLine("[1] Battle");
            Console.WriteLine("[2] Display stats");
            Console.WriteLine("[3] Display inventory");
            Console.WriteLine("[4] Upgrade skills");
            Console.WriteLine("[5] Save game");
            Console.WriteLine("[6] Load game");
            Console.WriteLine("[7] Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            storyOptions = int.Parse(Console.ReadLine());
            
            switch (storyOptions)
            {
                case 1:
                    BattleMenu(character);
                    break;
                case 2:
                    ShowCharacterStats(character);
                    break;
                case 3:
                    ShowInventory(character);
                    break;
                case 4:
                    UpgradeCharacterSkills(character);
                    break;
                case 5:
                    SaveCharacterStats(character);
                    break;
                case 6:
                    LoadCharacterStats(character);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Show character stats
    private void ShowCharacterStats(Character character)
    {
        Console.Clear();
        Console.WriteLine(character.GetAllStats());
        Console.WriteLine();
        Console.Write("Press any key to return to main menu ");
        Console.ReadLine();
    }

    // Show character inventory
    private void ShowInventory(Character character)
    {
        Console.Clear();
        character.Inventory.Display();
        Console.WriteLine();
        Console.WriteLine($"Heal potions: {character.GetHealPotions()}");
        Console.WriteLine($"Mana potions: {character.GetManaPotions()}");
        Console.WriteLine();
        Console.Write("Press any key to return to main menu ");
        Console.ReadLine();
    }

    // Upgrade character skills
    private void UpgradeCharacterSkills(Character character)
    {
        Console.Clear();
        character.UpgradeSkills(character.GetPointsToAssign());
    }

    // Save character stats to file
    private void SaveCharacterStats(Character character, string fileName = "GameSavedFile.csv")
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                // Writing the header for CSV (you can modify this if necessary)
                writer.WriteLine("LifePoints,ManaPoints,ExperiencePoints,PointsToAssign,Level,HealPotions,ManaPotions,PhysicalDamage,MagicDamage,AttackSpeed,Celerity,SpecialMoveTitle,SpecialMoveDamage");

                // Writing character stats to the file
                writer.WriteLine($"{character.GetLifePoints()},{character.GetManaPoints()},{character.GetExperiencePoints()},{character.GetPointsToAssign()},{character.GetLevel()},{character.GetHealPotions()},{character.GetManaPotions()},{character.GetPhysicalDamage()},{character.GetMagicDamage()},{character.GetAttackSpeed()},{character.GetCelerity()},{character.GetSpecialMoveTitle()},{character.GetSpecialMoveDamage()}");

                Console.WriteLine("Character stats have been saved successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    }


    // Load character stats from file
    private void LoadCharacterStats(Character character)
    {
        character.ChargeInformation(character, 0, 5, character.Inventory);
    }

    // Dungeon Introduction
    private void GetDungeonIntroduction()
    {
        Console.WriteLine("Welcome to the dungeon of the underworld");
        Console.WriteLine("You have entered a place of mystery and danger...");
        Console.WriteLine("Do you have what it takes to survive Underworld's Dungeon? Let the adventure begin!");
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        int option = 0;
        bool fileCharged = false;
        string PJToLoad = "";

        // Character objects
        PJArcher archer = new PJArcher();
        PJKnight knight = new PJKnight();
        PJWizard wizard = new PJWizard();

        // Main menu loop
        while (option != 3)
        {
            option = MainMenu(fileCharged);

            switch (option)
            {
                case 1:
                    CharacterSelection(ref fileCharged, ref PJToLoad);
                    break;
                case 2:
                    LoadCharacter(ref fileCharged, ref PJToLoad, archer, knight, wizard);
                    break;
                case 3:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Main Menu Options
    private static int MainMenu(bool fileCharged)
    {
        int option;
        if (fileCharged)
        {
            option = 1; // Load game automatically if charged
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Dungeon of the underworld");
            Console.WriteLine("[1] New game");
            Console.WriteLine("[2] Load game");
            Console.WriteLine("[3] Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
        }
        return option;
    }

    // Character Selection
    private static void CharacterSelection(ref bool fileCharged, ref string PJToLoad)
    {
        int optionSubMenu = 0;
        while (optionSubMenu != 4)
        {
            Console.Clear();
            Console.WriteLine("Choose your character");
            Console.WriteLine("[1] Archer");
            Console.WriteLine("[2] Knight");
            Console.WriteLine("[3] Wizard");
            Console.WriteLine("[4] Return to main menu");
            Console.Write("Select a choice from the menu: ");
            optionSubMenu = int.Parse(Console.ReadLine());

            switch (optionSubMenu)
            {
                case 1: // Archer
                    InitializeCharacter(new Archer());
                    break;
                case 2: // Knight
                    InitializeCharacter(new Knight());
                    break;
                case 3: // Wizard
                    InitializeCharacter(new Wizard());
                    break;
                case 4: // Return to main menu
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Load Character
    private static void LoadCharacter(ref bool fileCharged, ref string PJToLoad, PJArcher archer, PJKnight knight, PJWizard wizard)
    {
        Console.Clear();
        Console.WriteLine("[1] Archer");
        Console.WriteLine("[2] Knight");
        Console.WriteLine("[3] Wizard");
        Console.WriteLine("[4] Return to main menu");
        Console.Write("Select a character to load: ");
        int chargedStoryOption = int.Parse(Console.ReadLine());

        switch (chargedStoryOption)
        {
            case 1:
                if (archer.ChargeInformation(archer, 0, 5, archer.Inventory))
                {
                    fileCharged = true;
                    PJToLoad = "archer";
                }
                break;
            case 2:
                if (knight.ChargeInformation(knight, 0, 5, knight.Inventory))
                {
                    fileCharged = true;
                    PJToLoad = "knight";
                }
                break;
            case 3:
                if (wizard.ChargeInformation(wizard, 0, 5, wizard.Inventory))
                {
                    fileCharged = true;
                    PJToLoad = "wizard";
                }
                break;
            case 4:
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }
}
