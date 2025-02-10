using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public interface IPlayer
    {
        void Add(Player player);
        bool Remove(Player player);
        IEnumerable<Player> GetPlayers();
    }
}
