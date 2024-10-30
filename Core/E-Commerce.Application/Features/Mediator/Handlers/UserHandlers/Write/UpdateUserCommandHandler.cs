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
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IRepository<User> _repository;

        public UpdateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.UserId);
            values.PhoneNumber = request.PhoneNumber;
            values.Surname = request.Surname;
            values.Address = request.Address;
            values.IsAdmin = request.IsAdmin;
            values.Username = request.Username;
            values.Password = request.Password;
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
