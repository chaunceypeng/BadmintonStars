using MediatR;

namespace BadmintonStars.Application.Player.Commands.DeletePlayer
{
    public class DeletePlayerCommand : IRequest<int>
    {
        public int Id { get; set; }

        public DeletePlayerCommand(int id)
        {
            Id = id; 
        }
    }
}
