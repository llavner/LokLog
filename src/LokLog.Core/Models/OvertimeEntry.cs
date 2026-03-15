namespace LokLog.Core.Models;

public class OvertimeEntry(int id, Guid userId, DateTime date, decimal minutes, string description, DateTime createdAt, DateTime updatedAt)
{
    public int Id { get; set; } = id;
    public required Guid UserId { get; set; } = userId;
    public DateTime Date { get; set; } = date;
    public decimal Minutes { get; set; } = minutes;
    public string Description { get; set; } = description;
    public DateTime CreatedAt { get; set; } = createdAt;
    public DateTime UpdatedAt { get; set; } = updatedAt;
}
