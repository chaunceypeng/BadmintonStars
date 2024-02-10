using BadmintonStars.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Domain.Repositories
{
    public interface IPlayerRepository
    {
        public Task<List<Player>> GetAllPlayers();
        public Task<Player> AddPlayer(Player player);
    }
}
