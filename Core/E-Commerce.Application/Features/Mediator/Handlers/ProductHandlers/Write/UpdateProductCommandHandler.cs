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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ProductId);
            values.Description = request.Description;
            values.Price = request.Price;
            values.StockQuantity = request.StockQuantity;
            values.ImageUrl = request.ImageUrl;
            values.Name = request.Name;
            await _repository.UpdateAsync(values);
        }
    }
}
