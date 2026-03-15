namespace LokLog.Core.Models;

public class OvertimeEntry(int id, Guid userId, DateTime date, decimal minutes, string description, OvertimeCategory category, DateTime createdAt, DateTime updatedAt)
{
    public int Id { get; set; } = id;

    required public Guid UserId { get; set; } = userId;

    public DateTime Date { get; set; } = date;

    public decimal Minutes { get; set; } = minutes;

    public string Description { get; set; } = description;

    public OvertimeCategory Category { get; set; } = category;

    public DateTimeOffset CreatedAt { get; set; } = createdAt;

    public DateTimeOffset? UpdatedAt { get; set; } = updatedAt;
}

public enum OvertimeCategory
{
    Regular,
    Holiday,
    Emergency,
}