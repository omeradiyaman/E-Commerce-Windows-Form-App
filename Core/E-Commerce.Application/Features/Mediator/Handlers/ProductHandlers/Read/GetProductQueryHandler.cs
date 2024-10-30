using E_Commerce.Application.Features.Mediator.Queries.ProductQueries;
using E_Commerce.Application.Features.Mediator.Results.ProductResults;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Handlers.ProductHandlers.Read
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                Description = x.Description,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                ProductId = x.ProductId,
                StockQuantity = x.StockQuantity
            }).ToList();
        }
    }
}
