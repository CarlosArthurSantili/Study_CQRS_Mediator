using MediatR;
using Microsoft.AspNetCore.Mvc;
using Study_CQRS_Mediator_Shop.Domain.Commands.Requests;
using Study_CQRS_Mediator_Shop.Domain.Commands.Responses;

namespace Study_CQRS_Mediator_Shop.Controllers
{
    [ApiController]
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create
        (
            [FromServices]IMediator mediator,
            [FromBody]CreateCustomerRequest command
        )
        {
            return mediator.Send(command);
        }
    }    
}