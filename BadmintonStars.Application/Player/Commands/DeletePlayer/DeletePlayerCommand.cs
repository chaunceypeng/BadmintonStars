using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
