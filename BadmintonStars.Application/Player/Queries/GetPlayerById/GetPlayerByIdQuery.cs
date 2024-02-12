using BadmintonStars.Domain.Entities;
using MediatR;

namespace BadmintonStars.Application.Player.Queries.GetPlayerById
{
    public class GetPlayerByIdQuery : IRequest<PlayerModel>
    {
        public int Id { get; set; } 
        public GetPlayerByIdQuery(int id) 
        {
            Id = id;
        }
    }

   // public record GetPlayerByIdQuery(int Id) : IRequest<Domain.Entities.Player>;
}
