using EMS.Domain.Abstractions.IServices;
using MediatR;

namespace EMS.Application.Features.Booking.Command.BookEvent
{
    public class BookEventCommandHandler : IRequestHandler<BookEventCommand, Unit>
    {
        private readonly IBookingService _bookService;

        public BookEventCommandHandler(IBookingService bookService)
        {
            _bookService = bookService;
        }

        public async Task<Unit> Handle(BookEventCommand request, CancellationToken cancellationToken)
        {
            await _bookService.BookEventAsync(request.Id);
            return Unit.Value;

        }
    }
}
