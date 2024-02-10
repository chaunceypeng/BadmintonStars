using BadmintonStars.Domain.Entity;
using BadmintonStars.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BadmintonStars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public PlayerController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetAllPlayers()
        {
            var player = await _dataContext.Players.ToListAsync();

            return Ok(player);
        }
        

    }
}
