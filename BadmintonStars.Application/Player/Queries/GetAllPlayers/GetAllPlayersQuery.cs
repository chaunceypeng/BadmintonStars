using BadmintonStars.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonStars.Application.Player.Queries.GetAllPlayers
{
    public class GetAllPlayersQuery : IRequest<List<PlayerModel>>
    {
    }
}
