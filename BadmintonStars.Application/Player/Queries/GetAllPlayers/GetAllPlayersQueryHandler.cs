using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Application.Player.Queries.GetAllPlayers
{
    internal class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, List<PlayerModel>>
    {
        private readonly IPlayerRepository _playerRepository;

        public GetAllPlayersQueryHandler(IPlayerRepository playerRepository)
        {          
            _playerRepository = playerRepository;
        }


        public async Task<List<PlayerModel>> Handle(GetAllPlayersQuery request, CancellationToken cancellationToken)
        {
            return await _playerRepository.GetAllPlayers();
        }
    }
}
