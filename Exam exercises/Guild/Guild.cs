using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private string name;
        private int capacity;
        private HashSet<Player> players;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Players = new HashSet<Player>();
        }
        public int Count => this.players.Count;
        public string Name { get { return name; } set { name = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public HashSet<Player> Players { get { return players; } set { players = value; } }

        public void AddPlayer(Player player)
        {
            if (this.players.Count == this.Capacity == false)
            {
                players.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            if (players.Any(x => x.Name == name))
            {
                this.players.RemoveWhere(x => x.Name == name);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PromotePlayer(string name)
        {
            var player = players.First(x => x.Name == name);
            if ((player.Rank == "Member") == false)
            {
                player.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            var player = players.First(x => x.Name == name);
            if ((player.Rank == "Trial") == false)
            {
                player.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string klass)
        {
            var playersByClass = players.Where(x => x.Class == klass).ToArray();
            foreach (var player in playersByClass)
            {
                players.Remove(player);
            }
            return playersByClass;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in this.Players)
            {
                sb.AppendLine($"Player {player.Name}: {player.Class}");
                sb.AppendLine($"Rank: {player.Rank}");
                sb.AppendLine($"Description: {player.Description}");
            }
            return sb.ToString().Trim();
        }
    }
}