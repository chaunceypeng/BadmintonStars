using BadmintonStars.Application.Player.Commands;
using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using MediatR;

namespace BadmintonStars.Application.Player.Handlers
{
    public class AddPlayerCommandHandler : IRequestHandler<CreatePlayerCommand, PlayerModel>
    {
        private readonly IPlayerRepository _playerRepository;

        public AddPlayerCommandHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Task<PlayerModel> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var player = new PlayerModel() { FirstName = request.FirstName, LastName = request.LastName, Club = request.Club };
            _playerRepository.AddPlayer(player);
            return Task.FromResult(player);
        }
    }
}
