namespace lab10erick.Dtos;

public class CreateTicketRequest
{
    public Guid UserId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}