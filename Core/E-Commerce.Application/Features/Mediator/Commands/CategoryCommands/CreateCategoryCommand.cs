using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest
    {
        public required string Name { get; set; }
    }
}
