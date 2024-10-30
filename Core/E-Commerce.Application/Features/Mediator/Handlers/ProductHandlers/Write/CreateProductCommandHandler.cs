using E_Commerce.Application.Features.Mediator.Commands.ProductCommands;
using E_Commerce.Application.Interfaces;
using E_Commerce.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Features.Mediator.Handlers.ProductHandlers.Write
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                Description = request.Description,
                Name = request.Name,
                ImageUrl = request.ImageUrl,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                
            });
        }
    }
}
