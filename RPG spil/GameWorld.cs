using System;
namespace RPG_spil
{


    public class GameWorld
    {

        private Dictionary<string, Location> _locations;
        public GameWorld()
        {
            _locations = new Dictionary<string, Location>
          {
            {"City", new Location("The City", "a lively city filled regular people.") },
            {"Forest", new Location("The Forest", "is unpredictable and dangerous. Be careful!") }
          };


        }

        public void Travel(string locationName)
        {
            if (_locations.ContainsKey(locationName))
            {
                _locations[locationName].Enter();
            }
            else
            {
                Console.WriteLine("That place doesn't exist");
            }
        }

    }

}


