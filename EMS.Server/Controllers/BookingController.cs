using EMS.Application.Features.Booking.Command.BookEvent;
using EMS.Application.Features.Booking.Queries.GetUserBookings;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingController : ControllerBase
    {
        private readonly ISender _sender;

        public BookingController(ISender sender)
        {
            _sender = sender;
        }
        [HttpGet]
        public async Task<IActionResult> GetUserBookings()
        {
            var bookings = await _sender.Send(new GetUserBookingsQuery());
            return Ok(bookings);
        }

        [HttpPost]
        public async Task<IActionResult> BookAsync(BookEventCommand command)
        {
            await _sender.Send(command);
            return Ok(new { message = "Event booked successfully." });
        }
    }
}
