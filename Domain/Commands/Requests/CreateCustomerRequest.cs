using MediatR;
using Study_CQRS_Mediator_Shop.Domain.Commands.Responses;

namespace Study_CQRS_Mediator_Shop.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string? Name {get; set;}
        public string? Email {get; set;}
    }
}