namespace lab10erick.Dtos;

public class TicketResponseDto
{
    public Guid TicketId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public DateTime? CreatedAt { get; set; }
}