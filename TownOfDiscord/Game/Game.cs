using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TownOfDiscord.Game
{
    public abstract class Game
    {
        private List<Player> _players;
        private bool _hasStarted = false;
        private int _minPlayers = 3;

        public Game()
        {
            _players = new List<Player>();
        }

        public List<Player> Players
        {
            get { return _players; }
            private set { _players = value; }
        }

        public bool HasStarted
        {
            get { return _hasStarted; }
            internal set { _hasStarted = value; }
        }
        public int MinPlayers
        {
            get { return _minPlayers; }
            set
            {
                if (value <= 3)
                {
                    _minPlayers = value;
                }
            }
        }

        public bool AddPlayer(Player player)
        {
            try
            {
                if (_players.Contains(player) || _hasStarted)
                    return false;

                _players.Add(player);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public void AddPlayers(IEnumerable<Player> players)
        {
            try
            {
                if (_hasStarted)
                    return;

                foreach (Player currentPlayer in players)
                {
                    if (players.Contains(currentPlayer))
                        continue;

                    _players.Add(currentPlayer);
                }
                return;
            }
            catch
            {
                throw;
            }
        }

        public bool RemovePlayer(Player player)
        {
            try
            {
                if (!_players.Contains(player))
                    return false;

                _players.Remove(player);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public void ClearPlayers()
        {
            try
            {
                if (_hasStarted)
                    return;

                _players.Clear();
            }
            catch
            {
                throw;
            }
        }

        public virtual bool Start()
        {
            try
            {
                if (_hasStarted)
                    return false;

                Setup();
                Run();
                End();
            }
            catch
            {
                return false;
            }

            return true;
        }

        protected virtual void Setup()
        {
            if (_players.Count < _minPlayers - 1)
                throw new ArgumentOutOfRangeException();

            _hasStarted = true;
            Utilities.Shuffle(_players);

            for (int i = 0; i < _players.Count; i++)
            {
                // 1 in 3 is the Murderer
                if (i % 3 == 0)
                {
                    _players[i].role = Role.Murderer;
                }
                else
                {
                    _players[i].role = Role.Innocent;
                }
            }
        }

        protected abstract void Run();

        protected virtual void End()
        {
            _hasStarted = false;
            ClearPlayers();
        }

        public bool IsTeamAlive(Role role)
        {
            foreach (Player currentPlayer in _players)
            {
                if (currentPlayer.role == role)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            string players = "";

            foreach (Player currentPlayer in _players)
            {
                players += currentPlayer.ToString() + " ";
            }
            return players;
        }
    }
}
