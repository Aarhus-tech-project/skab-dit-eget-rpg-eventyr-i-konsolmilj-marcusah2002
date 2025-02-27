using System;

namespace RPG_spil
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player("Archer", 50, 10, 5);

           
            Enemy goblin = new Enemy("Goblin", 30, 5, 2);
            Enemy orc = new Enemy("Orc", 40, 9, 5 );
            Enemy evilWizard = new Enemy ("Evil Wizard", 50, 13, 9);

            Random random = new Random();
            Enemy[] enemies = {goblin, orc, evilWizard};
            Enemy currentEnemy = enemies[random.Next(enemies.Length)];

        

            
            Console.WriteLine($"A {currentEnemy.Name} appears! Battle starts!");

            player.Attack(currentEnemy);
            currentEnemy.Attack(player);

        }
    }
}
