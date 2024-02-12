using BadmintonStars.Domain.Repositories;
using BadmintonStars.Domain.Entities;
using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Application.Player.Commands.AddPlayer
{
    public class AddPlayerCommandHandler : IRequestHandler<AddPlayerCommand, PlayerModel>
    {
        private readonly IPlayerRepository _playerRepository;

        public AddPlayerCommandHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public Task<PlayerModel> Handle(AddPlayerCommand request, CancellationToken cancellationToken)
        {
            var player = new PlayerModel() { FirstName = request.FirstName, LastName = request.LastName, Club = request.Club };
            _playerRepository.AddPlayer(player);
            return Task.FromResult(player);
        }
    }
}
