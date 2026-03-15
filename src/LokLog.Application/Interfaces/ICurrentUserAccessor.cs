namespace LokLog.Application.Interfaces;

public interface ICurrentUserAccessor
{
    Guid GetUserId();
}
