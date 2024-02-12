using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Application.Player.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand, int>
    {
        private readonly IPlayerRepository _playerRepository;

        public UpdatePlayerCommandHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<int> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
        {
            var updatedPlayer = new PlayerModel()
            {
                // Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Club = request.Club
            };

            return await _playerRepository.UpdatePlayer(request.Id, updatedPlayer);
        } 
    }
}
