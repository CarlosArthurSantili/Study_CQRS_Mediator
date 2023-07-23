using Study_CQRS_Mediator_Shop.Domain.Commands.Requests;
using Study_CQRS_Mediator_Shop.Domain.Commands.Responses;

namespace Study_CQRS_Mediator_Shop.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}