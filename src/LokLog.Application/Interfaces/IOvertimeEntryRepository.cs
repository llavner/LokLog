using LokLog.Core.Models;

namespace LokLog.Application.Interfaces;

public interface IOvertimeEntryRepository
{
    Task<OvertimeEntry> GetByIdAsync(Guid id);

    Task<IReadOnlyList<OvertimeEntry>> SearchAsync(string userId, DateOnly from, DateOnly to);

    Task AddAsync(OvertimeEntry entry);

    Task UpdateAsync(OvertimeEntry entry);

    Task DeleteAsync(Guid id);
}
