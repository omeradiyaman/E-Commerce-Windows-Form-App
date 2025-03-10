using E_Commerce.Application.Features.Mediator.Commands.UserCommands;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Handlers.UserHandlers.Write
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IRepository<User> _repository;

        public CreateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new User
            {
                Name = request.Name,
                Password = request.Password,
                Surname = request.Surname,
                Username = request.Username,
                Address = request.Address,
                IsAdmin = false,
                PhoneNumber = request.PhoneNumber,

            });
        }
    }
}
