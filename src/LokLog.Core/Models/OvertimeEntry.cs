namespace LokLog.Core.Models;

internal class OvertimeEntry(int id, Guid userId, DateTime date, decimal minutes, string description, OvertimeCategory category, DateTime createdAt, DateTime updatedAt)
{
    internal int Id { get; set; } = id;

    required internal Guid UserId { get; set; } = userId;

    internal DateTime Date { get; set; } = date;

    internal decimal Minutes { get; set; } = minutes;

    internal string Description { get; set; } = description;

    internal OvertimeCategory Category { get; set; } = category;

    internal DateTimeOffset CreatedAt { get; set; } = createdAt;

    internal DateTimeOffset? UpdatedAt { get; set; } = updatedAt;
}

internal enum OvertimeCategory
{
    Regular,
    Holiday,
    Emergency,
}
