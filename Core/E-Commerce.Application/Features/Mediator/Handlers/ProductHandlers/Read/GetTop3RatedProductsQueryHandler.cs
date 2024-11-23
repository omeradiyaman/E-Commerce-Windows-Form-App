using E_Commerce.Application.Features.Mediator.Queries.ProductQueries;
using E_Commerce.Application.Features.Mediator.Results.ProductResults;
using E_Commerce.Application.Interfaces.ProductInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Handlers.ProductHandlers.Read
{
    public class GetTop3RatedProductsQueryHandler : IRequestHandler<GetTop3RatedProductsQuery, List<GetTop3RatedProductsQueryResult>>
    {
        private readonly IProductRepository _repository;

        public GetTop3RatedProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTop3RatedProductsQueryResult>> Handle(GetTop3RatedProductsQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetTop3RatedProducts();
            return values.Select(x => new GetTop3RatedProductsQueryResult
            {
                BrandName = x.BrandName,
                ImageUrl = x.ImageUrl,
                Price = x.Price,
                ProductName = x.ProductName,
            }).ToList();
        }
    }
}
