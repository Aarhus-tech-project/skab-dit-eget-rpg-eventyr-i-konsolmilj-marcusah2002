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
            {"city", new Location("The City.", "A big city filled with regular people.") },
            {"forest", new Location("The Forest", "It is unpredictable and dangerous. Be careful!") }
          };


        }

        public void Travel(string locationName)
        {

            string formattedLocation = locationName.ToLower();

            if (_locations.ContainsKey(formattedLocation))
            {
                _locations[formattedLocation].Enter();
            }
            else
            {
                Console.WriteLine("That place doesn't exist");
            }
        }

    }

}


