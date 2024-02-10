using BadmintonStars.Domain.Entity;
using BadmintonStars.Domain.Repositories;
using BadmintonStars.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Infrastructure.Repositories
{
    public class PlayerRepository(DataContext dataContext) : IPlayerRepository
    {
        private readonly DataContext _dataContext = dataContext;

        public async Task<List<Player>> GetAllPlayers()
        {
            return await _dataContext.Players.ToListAsync();
        }

        public async Task<Player> AddPlayer(Player player)
        {
            await _dataContext.Players.AddAsync(player);
            await _dataContext.SaveChangesAsync();
            return player;
        }
    }
}

