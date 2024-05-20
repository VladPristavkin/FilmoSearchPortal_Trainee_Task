using FilmoSearchPortal.Application.DTO.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilmoSearchPortal.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly ISender _sender;

        public ActorController(ISender sender)
        {
            _sender = sender;
        }
    }
}
