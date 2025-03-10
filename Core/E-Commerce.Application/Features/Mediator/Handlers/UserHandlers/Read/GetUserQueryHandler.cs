using E_Commerce.Application.Features.Mediator.Queries.UserQueries;
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
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, List<GetUserQueryResult>>
    {
        private readonly IRepository<User> _repository;

        public GetUserQueryHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetUserQueryResult>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetUserQueryResult
            {
                Name = x.Name,
                Password = x.Password,
                Surname = x.Surname,
                Username = x.Username,
                Address = x.Address,
                IsAdmin = x.IsAdmin,
                PhoneNumber = x.PhoneNumber,
                UserId = x.UserId,
            }).ToList();
        }
    }
}
