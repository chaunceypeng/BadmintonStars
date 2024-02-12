using BadmintonStars.Domain.Entities;
using MediatR;

namespace BadmintonStars.Application.Player.Queries.GetAllPlayers
{
    public class GetAllPlayersQuery : IRequest<List<PlayerModel>>
    {
    }
}
