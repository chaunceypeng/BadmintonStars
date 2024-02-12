using BadmintonStars.Domain.Entities;
using BadmintonStars.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Application.Player.Queries.GetPlayerById
{
    public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, PlayerModel>
    {
        private readonly IPlayerRepository _playerRepoistory;

        public GetPlayerByIdQueryHandler(IPlayerRepository playerRepoistory) 
        {
            _playerRepoistory = playerRepoistory;
        }

        public async Task<Domain.Entities.PlayerModel> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            return await _playerRepoistory.GetPlayerById(request.Id);
        }        
    }
}
