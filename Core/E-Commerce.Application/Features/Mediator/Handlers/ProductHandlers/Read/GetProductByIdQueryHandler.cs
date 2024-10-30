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
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                Description = values.Description,
                Name = values.Name,
                ImageUrl = values.ImageUrl,
                Price = values.Price,
                ProductId = values.ProductId,
                StockQuantity = values.StockQuantity,
            };
        }
    }
}
