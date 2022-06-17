using System.Text;

namespace Guild
{
    public class Player
    {
        private string name;
        private string klass;
        private string rank;
        private string description;

        public Player(string name, string klass)
        {
            this.Name = name;
            this.Class = klass;
            this.Rank = "Trial";
            this.Description = "n/a";
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Class
        {
            get { return this.klass; }
            set { this.klass = value; }
        }
        public string Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Player {this.Name}: {this.Class}");
            sb.AppendLine($"Rank: {this.Rank}");
            sb.AppendLine($"Description: {this.Description}");
            return sb.ToString().Trim();
        }
    }
}