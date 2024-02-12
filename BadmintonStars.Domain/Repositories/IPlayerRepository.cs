using BadmintonStars.Domain.Entities;

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
