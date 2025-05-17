using EMS.Application.Features.Events.Commands.CreateEvent;
using EMS.Application.Features.Events.Commands.DeleteEvent;
using EMS.Application.Features.Events.Commands.EditEvent;
using EMS.Application.Features.Events.Queries.GetEventById;
using EMS.Application.Features.Events.Queries.GetEvents;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetEventsList()
        {
            var response = await _mediator.Send(new GetEventsQuery());
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] GetEventByIdQuery request)
        {
            var response = await _mediator.Send(request);

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpPost]
        public async Task<int> AddEventAsync(CreateEventCommmand command)
        {
            return await _mediator.Send(command);
        }
        [HttpPut]
        public async Task<IActionResult> EditEventAsync([FromBody] EditEventCommmand command)
        {
            var result = await _mediator.Send(command);

            if (result == null) return NotFound();

            return Ok(result);

        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> RemoveAsync([FromRoute] DeleteEventCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result) return NotFound();

            return NoContent();
        }
    }
}
