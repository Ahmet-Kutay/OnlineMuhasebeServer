using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public abstract class CompaniesController : ControllerBase
    {
        private readonly IMediator _mediator;

        protected ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
