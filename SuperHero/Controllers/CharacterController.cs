using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperHerore.Application.Commands;
using System.Threading.Tasks;

namespace SuperHero.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;
        //const string SessionName = "_Name";
        private readonly IMediator _mediator;
        public CharacterController(ILogger<CharacterController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        [Route("Character/{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var command = new DetailCommand { Id = id };
            var model = await _mediator.Send(command);
            if(model.Error == "invalid id")
            {
                return View("NotFound");
            }
            return View(model);
        }

    }
}
