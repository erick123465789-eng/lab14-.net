using MediatR;
using Microsoft.AspNetCore.Mvc;
using lab10erick.Tickets.Commands;
using lab10erick.Tickets.Queries;

namespace lab10erick.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TicketsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetTickets()
    {
        var result = await _mediator.Send(new GetTicketsQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTicket(CreateTicketCommand command)
    {
        var ticketId = await _mediator.Send(command);
        return Ok(new { ticketId });
    }
}