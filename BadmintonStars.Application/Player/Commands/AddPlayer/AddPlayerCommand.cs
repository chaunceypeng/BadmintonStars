using BadmintonStars.Domain.Entities;
using MediatR;

namespace BadmintonStars.Application.Player.Commands.AddPlayer
{
    public class AddPlayerCommand : IRequest<PlayerModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Club { get; set; }

        public AddPlayerCommand(string firstName, string lastName, string club)
        {
            FirstName = firstName;
            LastName = lastName;
            Club = club;            
        }
    }
}
