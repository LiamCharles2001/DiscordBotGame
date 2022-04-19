using System;

namespace TownOfDiscord.Game
{
    public class Player : IEquatable<Player>
    {
        public ulong ID;
        public Role role;
        public string name;

        public Player()
        {
            role = Role.None;
            name = "";
        }

        public Player(ulong ID, string name)
        {
            this.ID = ID;
            this.name = name;
            role = Role.None;
        }

        public override string ToString()
        {
            return name;
        }

        public bool Equals(Player? other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }
}
