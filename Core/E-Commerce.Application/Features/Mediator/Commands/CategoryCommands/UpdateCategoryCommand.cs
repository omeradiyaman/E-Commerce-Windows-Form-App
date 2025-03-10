using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
    }
}
