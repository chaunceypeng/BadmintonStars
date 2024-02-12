using BadmintonStars.Application.Player.Commands.AddPlayer;
using BadmintonStars.Application.Player.Commands.DeletePlayer;
using BadmintonStars.Application.Player.Commands.UpdatePlayer;
using BadmintonStars.Application.Player.Queries.GetAllPlayers;
using BadmintonStars.Application.Player.Queries.GetPlayerById;
using BadmintonStars.Domain.Entities;
using BadmintonStars.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BadmintonStars.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PlayerController(IMediator mediator, DataContext dataContext)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlayerModel>>> GetAllPlayers()
        {
            var players = await _mediator.Send(new GetAllPlayersQuery());
            return Ok(players);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerModel>> GetPlayerById(int id)
        {
            var player = await _mediator.Send(new GetPlayerByIdQuery(id));
            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(AddPlayerCommand command)
        {
            var player = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetPlayerById), new { id = player.Id }, player);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlayer(int id, UpdatePlayerCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }

            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            await _mediator.Send(new DeletePlayerCommand(id));

            return NoContent();
        }
    }
}
