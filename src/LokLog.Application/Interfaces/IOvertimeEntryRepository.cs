namespace LokLog.Application.Interfaces;
using LokLog.Core.Models;

public interface IOvertimeEntryRepository
{
    Task<OvertimeEntry> GetByIdAsync(Guid id);

    Task<IReadOnlyList<OvertimeEntry>> SearchAsync(Guid userId, DateOnly from, DateOnly to);

    Task AddAsync(OvertimeEntry entry);

    Task UpdateAsync(OvertimeEntry entry);

    Task DeleteAsync(Guid id);
}
