using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using BadmintonStars.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BadmintonStars.Infrastructure.Repositories
{
    public class PlayerRepository(DataContext dataContext) : IPlayerRepository
    {
        private readonly DataContext _dataContext = dataContext;

        public async Task<List<PlayerModel>> GetAllPlayers()
        {
            return await _dataContext.Players.ToListAsync();
        }

        public async Task<PlayerModel?> GetPlayerById(int id)
        {
            return await _dataContext.Players.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);   
        }

        public async Task<PlayerModel> CreatePlayer(PlayerModel player)
        {
            await _dataContext.Players.AddAsync(player);
            await _dataContext.SaveChangesAsync();
            return player;
        }

        public async Task<int> UpdatePlayer(int id, PlayerModel player)
        {
            return await _dataContext.Players.Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.FirstName, player.FirstName)
                    .SetProperty(m => m.LastName, player.LastName)
                    .SetProperty(m => m.Club, player.Club)
                );
        }

        public async Task<int> DeletePlayer(int id)
        {
            return await _dataContext.Players
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
        }
    }
}

