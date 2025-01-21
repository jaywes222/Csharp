using System;

class SkeptiKraftsAdventure
{
    static void Main()
    {
        Console.WriteLine("Welcome to The SkeptiKrafts Adventure Game!");

        // Character setup
        Console.WriteLine("Enter Your Character's Name:");
        string playerName = Console.ReadLine();

        Console.WriteLine("Choose Your Character Type: (Warrior, Wizard, Archer)");
        string characterType = Console.ReadLine();

        Console.WriteLine($"You, {playerName} the {characterType}, find yourself at the edge of a dark forest.");
        Console.WriteLine("Do You Enter The Forest or Camp Outside? (Enter/Camp)");
        string choice1 = Console.ReadLine();

        if (choice1?.ToLower() == "enter")
        {
            Console.WriteLine("You Bravely Entered The Forest.");
        }
        else
        {
            Console.WriteLine("You Decided to Camp Out & Wait for Daylight.");
            Console.WriteLine("A safe choice, but the adventure ends here for now!");
            return; // Exit the game early if they choose to camp
        }

        // Game loop
        bool gameContinues = true;

        while (gameContinues)
        {
            Console.WriteLine("You Come to a Fork in the Road. Go Left or Right?");
            string direction = Console.ReadLine();

            if (direction?.ToLower() == "left")
            {
                Console.WriteLine("You Found a Treasure Chest! Inside is a pile of gold and jewels!");
                gameContinues = false; // End the game after finding the treasure
            }
            else if (direction?.ToLower() == "right")
            {
                Console.WriteLine("You Encountered A Wild Beast!");
                Console.WriteLine("Fight or Flee? (Fight/Flee)");
                string fightChoice = Console.ReadLine();

                if (fightChoice?.ToLower() == "fight")
                {
                    HandleCombat(ref gameContinues);
                }
                else
                {
                    Console.WriteLine("You Successfully Escaped, but at what cost?");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose Left or Right.");
            }
        }

        Console.WriteLine("Game Over. Thanks for playing!");
    }

    static void HandleCombat(ref bool gameContinues)
    {
        Random random = new Random();
        int luck = random.Next(1, 11); // Random number between 1 and 10

        if (luck > 5)
        {
            Console.WriteLine("You Beat the Wild Beast in a fierce battle!");
            if (luck > 8)
            {
                Console.WriteLine("The Wild Beast Dropped A Treasure! You're now rich beyond your dreams!");
            }
        }
        else
        {
            Console.WriteLine("The Beast Overpowered You. It Rammed Its Tusks into Your Chest...");
            Console.WriteLine("You Died a Hero's Death.");
            gameContinues = false; // End the game if the player dies
        }
    }
}
