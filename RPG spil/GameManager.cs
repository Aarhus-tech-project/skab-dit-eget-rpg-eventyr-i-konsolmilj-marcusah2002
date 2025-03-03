using RPG_spil;

public class GameManager
{
    private Player player;
    private GameWorld world;

    public GameManager()
    {
        world = new GameWorld();
        player = new Player("Archer", 50, 15, 5);
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to the RPG Adventure!");

        bool playing = true;
        while (playing)
        {
            Console.WriteLine("\nWhere do you want to go? (City/Forest/Quit)");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "quit")
            {
                playing = false;
                Console.WriteLine("Thanks for playing! See you next time.");
                break;
            }

            world.Travel(userChoice);


            if (userChoice.ToLower() == "city" || userChoice.ToLower() == "forest")
            {
                StartBattle();
            }
        }
    }


    private void StartBattle()
    {
        Enemy goblin = new Enemy("Goblin", 30, 5, 2);
        Enemy orc = new Enemy("Orc", 40, 9, 5);
        Enemy evilWizard = new Enemy("Evil Wizard", 50, 13, 7);

        Random random = new Random();
        Enemy[] enemies = { goblin, orc, evilWizard };
        Enemy currentEnemy = enemies[random.Next(enemies.Length)];

        Console.WriteLine($"A {currentEnemy.Name} appears! Battle starts!");

        while (player.Health > 0 && currentEnemy.Health > 0)
        {
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Potion");
            Console.WriteLine("3. Run Away");

            string input = Console.ReadLine();

            if (input == "1")
            {
                player.Attack(currentEnemy);
                if (currentEnemy.Health <= 0)
                {
                    Console.WriteLine($"{currentEnemy.Name} has been defeated!");
                    player.GainXP(10);
                    break;
                }
                
            }
            else if (input == "2")
            {
                player.UsePotion();
            }
            else if (input == "3")
            {
                Console.WriteLine("You ran away safely!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                continue;
            }

            
            if (currentEnemy.Health > 0)
            {
                currentEnemy.Attack(player);
            }

            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} has been defeated! Game over.");
                break;
            }
        }
    }
}

