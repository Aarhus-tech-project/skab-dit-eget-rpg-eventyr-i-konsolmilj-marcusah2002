using System;

namespace RPG_spil
{

    internal class Enemy : Character
    {
        public Enemy(string name, int health, int attackDamage, int defence)
            : base(name, health, attackDamage, defence)
        {
        }

        public void Attack(Player player)
        {
            Console.WriteLine($"{_name} attacks {player.Name}!");
            player.TakeDamage(_attackDamage);
        }
    }




}
