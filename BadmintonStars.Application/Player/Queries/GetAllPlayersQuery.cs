using BadmintonStars.Domain.Entities;
using MediatR;

namespace BadmintonStars.Application.Player.Queries
{
    public class GetAllPlayersQuery : IRequest<List<PlayerModel>>
    {
    }
}
