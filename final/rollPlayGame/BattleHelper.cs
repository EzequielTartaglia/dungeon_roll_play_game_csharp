using System;

public static class BattleHelper
{
    public static void UpgradeStatsBasedOnLevel(NPC enemy, int enemyLevel)
    {
        if (enemyLevel > 1)
        {
            enemy.SetlifePoints(enemy.GetlifePoints() + ((enemy.GetlifePoints() * enemyLevel) / 6));
            enemy.SetManaPoints(enemy.GetManaPoints() + ((enemy.GetManaPoints() * enemyLevel) / 6));
            enemy.SetPhysicalDamage(enemy.GetPhysicalDamage() + ((enemy.GetPhysicalDamage() * enemyLevel) / 12));
            enemy.SetMagicDamage(enemy.GetMagicDamage() + ((enemy.GetMagicDamage() * enemyLevel) / 7));
            enemy.SetAttackSpeed(enemy.GetAttackSpeed() + ((enemy.GetAttackSpeed() * enemyLevel) / 20));
            enemy.SetCelerity(enemy.GetCelerity() + ((enemy.GetCelerity() * enemyLevel) / 20));
            enemy.SetSpecialMoveDamage(enemy.GetSpecialMoveDamage() + ((enemy.GetSpecialMoveDamage() * enemyLevel) / 20));
        }
    }

    public static void HandleBattle(NPC hero, NPC enemy, string enemyTypeName)
    {
        Console.Clear();
        Console.WriteLine($"Continuing with your journey inside the dungeon, you encounter a level {enemy.GetLevel()} {enemyTypeName}, who faces you in a challenging battle.");
        Console.WriteLine($"Our hero has {hero.GetlifePoints()} life points.");
        Console.WriteLine($"The {enemyTypeName} has {enemy.GetlifePoints()} life points.");
        Console.WriteLine();

        while (hero.GetlifePoints() > 0 && enemy.GetlifePoints() > 0)
        {
            Console.Clear();
            Console.WriteLine($"{enemyTypeName}'s life points: {enemy.GetlifePoints()}, Mana points: {enemy.GetManaPoints()}.");
            Console.WriteLine($"Your life points: {hero.GetlifePoints()}, Mana points: {hero.GetManaPoints()}.");
            Console.WriteLine();
            Console.WriteLine("[1] Physical attack");
            Console.WriteLine("[2] Magic attack (Mana -10)");
            Console.WriteLine("[3] Special move attack (Mana -15)");
            Console.WriteLine("[4] Use heal potion");
            Console.WriteLine("[5] Use mana potion");
            Console.WriteLine();
            Console.WriteLine("Note: If you try to use an attack that requires mana or use potions without enough mana, it will be considered as a turn over with no action.");
            Console.Write("Select an action: ");
            
            int actionChoice = int.Parse(Console.ReadLine());
            switch (actionChoice)
            {
                case 1: // Physical attack
                    HandleAttack(hero, enemy, (h, e) => h.AttackPhysicalDamagePJ(e));
                    break;
                case 2: // Magic attack
                    HandleAttack(hero, enemy, (h, e) => h.AttackMagicDamagePJ(e));
                    break;
                case 3: // Special move
                    HandleAttack(hero, enemy, (h, e) => h.AttackSpecialMovePJ(e));
                    break;
                case 4: // Heal potion
                    UsePotion(hero, enemy, "heal");
                    break;
                case 5: // Mana potion
                    UsePotion(hero, enemy, "mana");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }

        // Outcome after battle
        if (hero.GetlifePoints() <= 0)
        {
            Console.WriteLine($"The {enemyTypeName} defeats you, and your adventure ends here.");
            GameOver();
        }
        else
        {
            WinBattle(hero, enemy, enemyTypeName);
        }
    }

    public static void WinBattle(NPC hero, NPC enemy, string enemyTypeName)
    {
        Console.Clear();
        Console.WriteLine($"After a relentless battle, you defeated the {enemyTypeName} and can continue your journey.");

        // Add experience, potions, and items based on the enemy type
        int experienceReceived = 100 * enemy.GetLevel();
        hero.AddExperience(experienceReceived);
        int potionReceived = 1 * enemy.GetLevel();
        hero.SetHealPotions(hero.GetHealPotions() + potionReceived);
        hero.SetManaPotions(hero.GetManaPotions() + potionReceived);

        // Collect item
        Item item = new Item($"{enemyTypeName} shard", 1);
        hero.AddItemToInventory(item);

        Console.WriteLine($"You received {experienceReceived} experience points, {potionReceived} potions, and a {item.GetName()}.");
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadLine();
    }

    public static void UsePotion(NPC hero, NPC enemy, string potionType)
    {
        Console.Clear();
        Random random = new Random();

        if (hero.GetCelerity() > enemy.GetCelerity())
        {
            if (potionType == "heal")
                hero.DrinkHealPotion();
            else
                hero.DrinkManaPotion();

            // Enemy's turn to attack
            EnemyAttack(enemy, hero);
        }
        else
        {
            // Enemy's turn to attack first
            EnemyAttack(enemy, hero);

            if (potionType == "heal")
                hero.DrinkHealPotion();
            else
                hero.DrinkManaPotion();
        }

        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }

    public static void EnemyAttack(NPC enemy, NPC hero)
    {
        Random random = new Random();
        int attackType = random.Next(3);
        switch (attackType)
        {
            case 0:
                enemy.AttackPhysicalDamageNPC(hero);
                break;
            case 1:
                enemy.AttackMagicDamageNPC(hero);
                break;
            case 2:
                enemy.AttackSpecialMoveNPC(hero);
                break;
        }
    }

    public static void HandleAttack(NPC hero, NPC enemy, Action<NPC, NPC> heroAttackMethod)
    {
        Console.Clear();

        bool heroFirst = hero.GetCelerity() > enemy.GetCelerity();

        // Hero attacks first
        if (heroFirst)
        {
            heroAttackMethod(hero, enemy);
            EnemyAttack(enemy, hero);
        }
        else
        {
            EnemyAttack(enemy, hero);
            heroAttackMethod(hero, enemy);
        }

        Console.Write("Press any key to return to continue ");
        Console.ReadLine();
    }
}
