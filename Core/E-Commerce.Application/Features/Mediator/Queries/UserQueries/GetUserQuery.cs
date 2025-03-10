using E_Commerce.Application.Features.Mediator.Results.UserResuls;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Queries.UserQueries
{
    public class GetUserQuery : IRequest<List<GetUserQueryResult>>
    {
    }
}
