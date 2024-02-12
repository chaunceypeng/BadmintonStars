using BadmintonStars.Application.Player.Queries;
using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using MediatR;

namespace BadmintonStars.Application.Player.Handlers
{
    public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, PlayerModel?>
    {
        private readonly IPlayerRepository _playerRepoistory;

        public GetPlayerByIdQueryHandler(IPlayerRepository playerRepoistory)
        {
            _playerRepoistory = playerRepoistory;
        }

        public async Task<PlayerModel?> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            return await _playerRepoistory.GetPlayerById(request.Id);
        }
    }
}
