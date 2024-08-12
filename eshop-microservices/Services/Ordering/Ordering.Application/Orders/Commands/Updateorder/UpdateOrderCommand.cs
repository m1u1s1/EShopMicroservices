﻿using FluentValidation;

namespace Ordering.Application.Orders.Commands.Updateorder;


public record UpdateOrderResult(bool IsSuccess);
public record UpdateOrderCommand (OrderDto Order)
    : ICommand<UpdateOrderResult>;



public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderCommandValidator()
    {
        RuleFor(x => x.Order.Id).NotEmpty().WithMessage("id is required");
        RuleFor(x => x.Order.OrderName).NotEmpty().WithMessage("Name is required");
        RuleFor(x => x.Order.CustomerId).NotNull().WithMessage("CustomerId is required");
    }
}
