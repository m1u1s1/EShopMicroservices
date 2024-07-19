﻿using MediatR;

namespace Catalog.API.Products.CreateProduct;


public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price) 
    : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);


// Vertical slcie architecture
//cqrs library to execute the commands or queries
//with mediator receives a request and process it, encapsulates business logic

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //Business logic to create a product
        throw new NotImplementedException();
    }
}
