using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_spil
{
   public class Location
    {
        public string Name { get; set; }
        public string Description { get;}


        public Location(string name, string description)
        {  
            Name = name; 
            Description = description; 
        }

        public void Enter()
        {
            Console.WriteLine($"You arrived at {Name}");
            Console.WriteLine($"{Description}");
        }

    }
}
