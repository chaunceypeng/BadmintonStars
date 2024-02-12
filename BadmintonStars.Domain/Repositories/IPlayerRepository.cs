using BadmintonStars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Domain.Repositories
{
    public interface IPlayerRepository
    {
        public Task<List<PlayerModel>> GetAllPlayers();
        public Task<PlayerModel> GetPlayerById(int id);
        public Task<PlayerModel> AddPlayer(PlayerModel player);
        public Task<int> UpdatePlayer(int id, PlayerModel player);
        public Task<int> DeletePlayer(int id);
    }
}
