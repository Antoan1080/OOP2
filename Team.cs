using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1080
{
    internal class Team
    {
        public Coach Coach { get; set; }
        public List<Player> Players
        {
            get { return Players; }
            set 
            {

                if (value.Count < 11 || value.Count > 22)
                {
                    throw new Exception("Players must be min. 11, up to 22");
                }
                Players = value;
            }

        }
        public Team(Coach coach, List<Player> players)
        {
            Coach = coach;
            Players = players;
        }
        public double AverageAge()
        {
            int _age = 0;
            double averageAge;
            foreach (Player player in Players)
            {
                _age += player.Age;
            }
            averageAge = _age / Players.Count;

            return averageAge;
        }

    }
}
