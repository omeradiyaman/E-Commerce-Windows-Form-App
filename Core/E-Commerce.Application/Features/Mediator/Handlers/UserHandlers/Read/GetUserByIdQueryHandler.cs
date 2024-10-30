using E_Commerce.Application.Features.Mediator.Queries.UserQueries;
using E_Commerce.Application.Features.Mediator.Results.ProductResults;
using E_Commerce.Application.Features.Mediator.Results.UserResuls;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Handlers.UserHandlers.Read
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdQueryResult>
    {
        private readonly IRepository<User> _repository;

        public GetUserByIdQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<GetUserByIdQueryResult> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetUserByIdQueryResult
            {
                Name = values.Name,
                Password = values.Password,
                Surname = values.Surname,
                Username = values.Username,
                UserId = values.UserId,
                Address = values.Address,
                IsAdmin = values.IsAdmin,
                PhoneNumber = values.PhoneNumber
            };
        }
    }
}
