using System;
using RPG_spil;

namespace RPG_spil
{

    public class Character
    {
        //Fields
        protected string _name;
        protected int _health;
        protected int _attackDamage;
        protected int _defence;

        public string Name { get { return _name; } }
        public int Health { get { return _health; } }

        //Constructor
        public Character(string name, int health, int attackDamage, int defence)
        {
            _name = name;
            _health = health;
            _attackDamage = attackDamage;
            _defence = defence;


        }

        //Methods
        public void Attack(Character target)
        {

            int damageDealt = _attackDamage - target._defence;
            if (damageDealt < 1) damageDealt = 1;

            Console.WriteLine($"{_name} attacks {target.Name} for {damageDealt}");
            target.TakeDamage(damageDealt);
        }

        public void TakeDamage(int damageDealt)
        {
            _health -= damageDealt;  
            Console.WriteLine($"{_name} takes {damageDealt} damage! Health left: {_health}");

            
        }
    }



}