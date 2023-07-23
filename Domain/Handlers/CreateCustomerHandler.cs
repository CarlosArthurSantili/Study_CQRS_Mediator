using MediatR;
using Study_CQRS_Mediator_Shop.Domain.Commands.Requests;
using Study_CQRS_Mediator_Shop.Domain.Commands.Responses;

namespace Study_CQRS_Mediator_Shop.Domain.Handlers
{
    public class CreateCustomerHandler : 
    IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Validacoes
            //Retorno
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Arthur Santili",
                Email = "email@email.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}