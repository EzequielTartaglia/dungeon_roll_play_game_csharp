using System;
//Public class to can use in "other window"

// this class must also be declared as an abstract class (because have an abstract method inside).
public abstract class BasePlayerCharacter
{
    //Protect class inside the propieties to not affect the working of the program (only the inherit class)
    public int _life;
    protected int _mana;
    protected int _experience;
    protected int _pointsToAssign; //Quantity of number of skills to improve
    protected int _lvl; //Determine the skills
    protected int _healpotion;
    protected int _manaPotion;
    protected int _physicalDamage; //Determine strengh of hit
    protected int _magicDamage; //Magical power (spells)
    protected int _attackSpeed; //Posibility to do "combos" (2 hits in the same turn for example)
    protected int _celerity; //Determine who start in the battle (speed to do the first attack)
    protected string _specialMoveTitle;
    protected int _specialMoveDamage;

    //List of items the PJ has
    protected List<string> _inventaryBag = new List<string>();

    //----------- Constructors section (templates)--------------

    //The default BasePlayerCharacter when we create
    public BasePlayerCharacter()
    {
        //Default values
        _life = 1;
        _mana = 0;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }

    //When the user only put 1 parameter
    public BasePlayerCharacter(int lifePoints)
    {

        _life = lifePoints;
        _mana = 0;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 2 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = 0;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 3 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = 0;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 4 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = 0;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 5 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = 1;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 6 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = 0;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 7 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = 0;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 8 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = 0;
        _celerity = 0;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 9 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = 0;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 10 parameter
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;
        _specialMoveTitle = "";
        _specialMoveDamage = 0;
    }
    //When the user only put 11 parameters
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = 0;
    }
    //When the user put 12 parameters
    public BasePlayerCharacter(int lifePoints, int manaPoints, int experiencePoints, int healPotions, int manaPotions, int level, int physicalDamage, int magicDamage, int attackSpeed, int celerity, int pointsToAssign, string specialMoveTitle, int specialMoveDamage)
    {
        _life = lifePoints;
        _mana = manaPoints;
        _experience = experiencePoints;
        _healpotion = healPotions;
        _manaPotion = manaPotions;
        _lvl = level;
        _physicalDamage = physicalDamage;
        _magicDamage = magicDamage;
        _attackSpeed = attackSpeed;
        _celerity = celerity;
        _pointsToAssign = pointsToAssign;
        _specialMoveTitle = specialMoveTitle;
        _specialMoveDamage = specialMoveDamage;
    }
    //----------- Constructors section (templates)--------------
    //------------- (Methods - Behaviors) -----------------------
    //----------------- Getter & Setter section -----------------
    public int GetlifePoints()
    {
        //See the value of _life
        return _life;
    }
    public void SetlifePoints(int lifePoints)
    {
        //Put the value of _life
        _life = lifePoints;
    }

    public int GetManaPoints()
    {
        //See the value of _mana
        return _mana;
    }
    public void SetManaPoints(int manaPoints)
    {
        //Put the value of _mana
        _mana = manaPoints;
    }

    public int GetExperiencePoints()
    {
        //See the value of _experience
        return _experience;
    }
    public void SetExperiencePoints(int experiencePoints)
    {
        //Put the value of _experience
        _experience = experiencePoints;
    }

    public int GetHealPotions()
    {
        //See the value of _healpotion
        return _healpotion;
    }
    public void SetHealPotions(int healPotions)
    {
        //Put the value of _manaPotion
        _healpotion = healPotions;
    }

    public int GetManaPotions()
    {
        //See the value of _manaPotion
        return _manaPotion;
    }
    public void SetManaPotions(int manaPotions)
    {
        //Put the value of _life
        _manaPotion = manaPotions;
    }

    public int GetLevel()
    {
        //See the value of _lvl
        return _lvl;
    }
    public void SetLevel(int level)
    {
        //Put the value of _lvl
        _lvl = level;
    }

    public int GetPhysicalDamage()
    {
        //See the value of _life
        return _physicalDamage;
    }
    public void SetPhysicalDamage(int physicalDamage)
    {
        //Put the value of _life
        _physicalDamage = physicalDamage;
    }

    public int GetMagicDamage()
    {
        //See the value of _magicDamage
        return _magicDamage;
    }
    public void SetMagicDamage(int magicDamage)
    {
        //Put the value of _magicDamage
        _magicDamage = magicDamage;
    }

    public int GetAttackSpeed()
    {
        //See the value of _attackSpeed
        return _attackSpeed;
    }
    public void SetAttackSpeed(int attackSpeed)
    {
        //Put the value of _attackSpeed
        _attackSpeed = attackSpeed;
    }

    public int GetCelerity()
    {
        //See the value of _celerity
        return _celerity;
    }
    public void SetCelerity(int celerity)
    {
        //Put the value of _celerity
        _celerity = celerity;
    }

    public int GetPointsToAssign()
    {
        //See the value of _pointsToAssign
        return _pointsToAssign;
    }
    public void SetPointsToAssign(int pointsToAssign)
    {
        //Put the value of _pointsToAssign
        _pointsToAssign = pointsToAssign;
    }

    public string GetSpecialMoveTitle()
    {
        //See the value of _specialMoveTitle
        return _specialMoveTitle;
    }
    public void SetSpecialMoveTitle(string specialMoveTitle)
    {
        //Put the value of _specialMoveTitle
        _specialMoveTitle = specialMoveTitle;
    }

    public int GetSpecialMoveDamage()
    {
        //See the value of _specialMoveDamage
        return _specialMoveDamage;
    }
    public void SetSpecialMoveDamage(int specialMoveDamage)
    {
        //Put the value of _specialMoveDamage
        _specialMoveDamage = specialMoveDamage;
    }

    //----------------- Getter & Setter section -----------------
    //------------------------- Methods -------------------------

    //Function to attack (Physical)
    public void AttackPhysicalDamagePJ(Object objetive)
    {

        if (objetive is NPCOrc)
        {
            ((NPCOrc)objetive)._life -= _physicalDamage;
            Console.WriteLine($"Our hero attacks the orc and inflicts {_physicalDamage} points of physical damage on him.");
            Console.WriteLine();

        }
        if (objetive is NPCBanshee)
        {
            ((NPCBanshee)objetive)._life -= _physicalDamage;
            Console.WriteLine($"Our hero attacks the banshee and inflicts {_physicalDamage} points of physical damage on him.");
            Console.WriteLine();

        }
        if (objetive is NPCSkull)
        {
            ((NPCSkull)objetive)._life -= _physicalDamage;
            Console.WriteLine($"Our hero attacks the skull warrior and inflicts {_physicalDamage} points of physical damage on him.");
            Console.WriteLine();

        }

    }

    //Function to attack (Magic)
    public void AttackMagicDamagePJ(Object objetive)
    {
        if (_mana >= 10)
        {
            if (objetive is NPCOrc)
            {
                ((NPCOrc)objetive)._life -= _magicDamage;
                Console.WriteLine($"Our hero attacks the orc and inflicts {_magicDamage} points of magic damage on him.");
                Console.WriteLine();
                _mana -= 10;

            }
            if (objetive is NPCBanshee)
            {
                ((NPCBanshee)objetive)._life -= _magicDamage;
                Console.WriteLine($"Our hero attacks the banshee and inflicts {_magicDamage} points of magic damage on him.");
                Console.WriteLine();
                _mana -= 10;
            }
            if (objetive is NPCSkull)
            {
                ((NPCSkull)objetive)._life -= _magicDamage;
                Console.WriteLine($"Our hero attacks the skull warrior and inflicts {_magicDamage} points of magic damage on him.");
                Console.WriteLine();
                _mana -= 10;
            }
        }
        else
        {
            Console.WriteLine("Our hero doesn't have enough mana. You lose your turn to attack.");
            Console.WriteLine();

        }
    }

    //Function to attack (Special move)
    public void AttackSpecialMovePJ(Object objetive)
    {

        if (_mana >= 15)
        {
            if (objetive is NPCOrc)
            {
                ((NPCOrc)objetive)._life -= _specialMoveDamage;
                Console.WriteLine($"Our hero attacks the orc, dealing {_specialMoveDamage} damage with {_specialMoveTitle}, his special ability.");
                Console.WriteLine();
                _mana -= 15;

            }
            if (objetive is NPCBanshee)
            {
                ((NPCBanshee)objetive)._life -= _specialMoveDamage;
                Console.WriteLine($"Our hero attacks the banshee, dealing {_specialMoveDamage} damage with {_specialMoveTitle}, his special ability.");
                Console.WriteLine();
                _mana -= 15;

            }
            if (objetive is NPCSkull)
            {
                ((NPCSkull)objetive)._life -= _specialMoveDamage;
                Console.WriteLine($"Our hero attacks the skull warrior, dealing {_specialMoveDamage} damage with {_specialMoveTitle}, his special ability.");
                Console.WriteLine();
                _mana -= 15;

            }
        }
        else
        {
            Console.WriteLine("Our hero doesn't have enough mana. You lose your turn to attack.");
            Console.WriteLine();

        }
    }

    //Function to drink a heal potion
    public void DrinkHealPotion()
    {
        //If you have potions
        if (_healpotion > 0)
        {
            //Progressive depends the level
            int recoveryPoints = _lvl * 50;
            _life += recoveryPoints;
            Console.WriteLine($"Our hero drinks an heal potion and recovery {recoveryPoints}.");
            Console.WriteLine($"Our hero has {_life} life points now.");
            Console.WriteLine();

            //Rest one potion
            _healpotion--;
        }
        else
        {
            Console.WriteLine("Our hero doesn't have enough heal potions. You lose your turn.");
            Console.WriteLine();
        }
    }

    //Function to drink a mana potion
    public void DrinkManaPotion()
    {
        //If you have potions
        if (_manaPotion > 0)
        {
            //Progressive depends the level
            int recoveryPoints = _lvl * 50;
            _mana += recoveryPoints;
            Console.WriteLine($"Our hero drinks an heal potion and recovery {recoveryPoints}.");
            Console.WriteLine($"Our hero has {_mana} mana points now.");
            Console.WriteLine();

            //Rest one potion
            _manaPotion--;
        }
        else
        {
            Console.WriteLine("Our hero doesn't have enough mana potions. You lose your turn.");
            Console.WriteLine();
        }
    }


    //Function to add experience in the battle
    public void AddExperience(int enemyLevel)
    {
        _experience += 100 * enemyLevel;

        if (_experience >= 1000 * _lvl)
        {
            //Lvl up
            _lvl = _lvl + 1;

            //Modify the stats (upgrade when lvl up)
            _life = _life + (30 * _lvl);
            _mana = _mana + (30 * _lvl);
            _physicalDamage = _physicalDamage + (10 * _lvl);
            _magicDamage = _magicDamage + (10 * _lvl);
            _attackSpeed = _attackSpeed + (5 * _lvl);
            _celerity = _celerity + (5 * _lvl);
            _specialMoveDamage = _specialMoveDamage + (15 * _lvl);

            //Add points to assign
            _pointsToAssign = _pointsToAssign + 5;

            //Reset experience
            _experience = 0;

            Console.WriteLine($"Congratulations I have leveled up, now our hero's level is {_lvl}!");

        }
    }

    //Method to add one item to the inventary
    public void AddToInventaryBag(string item, int quantity)
    {
        //example to use
        //myObject.AddToInventaryBag("LifePotion", 3);

        bool itemExists = false;

        //Iteration of the list
        for (int i = 0; i < _inventaryBag.Count; i++)
        {
            //If the item exist in the inventary
            if (_inventaryBag[i].Contains(item))
            {
                string[] parts = _inventaryBag[i].Split(' ');
                int currentQuantity = int.Parse(parts[0]);
                _inventaryBag[i] = (currentQuantity + quantity) + " " + item;
                itemExists = true;
                break;
            }
        }
        //If the item not exist in the inventary
        if (!itemExists)
        {
            _inventaryBag.Add(quantity + " " + item);
        }
    }

    //Method to see the stats
    public virtual string GetAllStats()
    {
        //Create the variable to return all the stats
        string stats = "";
        //Add all the stats
        Console.WriteLine("Dungeon of the underworld");
        Console.WriteLine();
        stats = stats + $"Life: {GetlifePoints()}" + "\n";
        stats = stats + $"Mana: {GetManaPoints()}" + "\n";
        stats = stats + $"Lvl: {GetLevel()}" + "\n";
        stats = stats + $"Physical Damage: {GetPhysicalDamage()}" + "\n";
        stats = stats + $"Magical Damage: {GetMagicDamage()}" + "\n";
        stats = stats + $"Attack Speed: {GetAttackSpeed()}" + "\n";
        stats = stats + $"Celerity: {GetCelerity()}" + "\n";

        return stats;

    }

    //Method to upgrade the skills
    public virtual int UpgradeSkills(int pointsToAssign)
    {
        Console.Clear();
        _pointsToAssign = pointsToAssign;

        //Check if there are points to assign
        if (_pointsToAssign <= 0)
        {
            Console.WriteLine("No points to assign");
            return _pointsToAssign;
        }
        Console.WriteLine("Dungeon of the underworld");
        Console.WriteLine();
        Console.WriteLine("Write the number of the skill to upgrade.");
        Console.WriteLine();
        Console.WriteLine("[1] Life points");
        Console.WriteLine("[2] Mana points");
        Console.WriteLine("[3] Physical damage");
        Console.WriteLine("[4] Magic damage");
        Console.WriteLine("[5] Attack speed");
        Console.WriteLine("[6] Celerity");
        //Console.WriteLine("[7] Special skill");
        Console.WriteLine("[7] Back menu");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        int skillToUpgrade = int.Parse(Console.ReadLine());

        //Loop until a valid option is selected
        while (skillToUpgrade < 1 || skillToUpgrade > 7)
        {
            Console.WriteLine("Invalid option, try again");
            Console.Write("Select a choice from the menu: ");
            skillToUpgrade = int.Parse(Console.ReadLine());
        }

        //Add one point to the stats and change the propieties of the character
        //Then subtract 1 point to assign
        switch (skillToUpgrade)
        {
            case 1:
                SetlifePoints(GetlifePoints() + 50);
                _pointsToAssign--;
                break;

            case 2:
                SetManaPoints(GetManaPoints() + 50);
                _pointsToAssign--;
                break;

            case 3:
                SetPhysicalDamage(GetPhysicalDamage() + 5);
                _pointsToAssign--;
                break;

            case 4:
                SetMagicDamage(GetMagicDamage() + 5);
                _pointsToAssign--;
                break;

            case 5:
                SetAttackSpeed(GetAttackSpeed() + 5);
                _pointsToAssign--;
                break;

            case 6:
                SetCelerity(GetCelerity() + 5);
                _pointsToAssign--;
                break;

            case 8:
                break;
        }
        SetPointsToAssign(_pointsToAssign);
        return _pointsToAssign;
    }

    //Function to charge the stats (load)
    public bool ChargeInformation(BasePlayerCharacter character, int userExperiencePoints, int userPointsToAssign, Inventory characterInventory, bool fileCharged = false)
    {
        Console.WriteLine();
        Console.Write("What is the filename for the game file? ");
        string fileName = Console.ReadLine();


        //Test if the file exist in the folder (is not exist, not charge)
        if (File.Exists(fileName))
        {

            //Load all the lines in the file
            using (StreamReader inputFile = new StreamReader(fileName))
            {



                userExperiencePoints = int.Parse(inputFile.ReadLine());
                userPointsToAssign = int.Parse(inputFile.ReadLine());

                //Charge the stats in the load file
                character.SetlifePoints(int.Parse(inputFile.ReadLine()));
                character.SetManaPoints(int.Parse(inputFile.ReadLine()));
                character.SetExperiencePoints(int.Parse(inputFile.ReadLine()));
                character.SetPointsToAssign(int.Parse(inputFile.ReadLine()));
                character.SetLevel(int.Parse(inputFile.ReadLine()));
                character.SetHealPotions(int.Parse(inputFile.ReadLine()));
                character.SetManaPotions(int.Parse(inputFile.ReadLine()));
                character.SetPhysicalDamage(int.Parse(inputFile.ReadLine()));
                character.SetMagicDamage(int.Parse(inputFile.ReadLine()));
                character.SetAttackSpeed(int.Parse(inputFile.ReadLine()));
                character.SetCelerity(int.Parse(inputFile.ReadLine()));
                character.SetSpecialMoveTitle(inputFile.ReadLine());
                character.SetSpecialMoveDamage(int.Parse(inputFile.ReadLine()));

                //For each line in the file, create an instance of the item and add it to the inventory
                while (!inputFile.EndOfStream)
                {
                    //Divide the lines in the charged file
                    string line = inputFile.ReadLine();
                    string[] itemData = line.Split(',');

                    //Check if the itemData array has at least two elements
                    if (itemData.Length >= 2)
                    {
                        //Create the item and the propieties
                        Item item = new Item();
                        item.SetName(itemData[0]);
                        int quantity;
                        if (int.TryParse(itemData[1], out quantity))
                        {
                            item.SetQuantity(quantity);

                            //Add the item to the inventory 
                            characterInventory.AddItemToInventory(item);
                        }
                        else
                        {
                            Console.WriteLine("Invalid value for item quantity in the file: " + itemData[1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid line in the file: " + line);
                    }
                }
            }

            return fileCharged = true;
        }
        else
        {
            Console.WriteLine("File not found.");
            Console.WriteLine();
            Console.Write("Press any key to return to main menu ");
            Console.ReadLine();
            Console.Clear();
            return fileCharged;
        }

    }

}
