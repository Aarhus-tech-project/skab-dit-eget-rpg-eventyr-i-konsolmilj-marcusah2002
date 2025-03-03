using System;

namespace RPG_spil
{

    public class Enemy : Character
    {
        public Enemy(string name, int health, int attackDamage, int defence)
            : base(name, health, attackDamage, defence)
        {
        }

        public int Health
        {
            get { return _health; }
        }

        
    }




}
