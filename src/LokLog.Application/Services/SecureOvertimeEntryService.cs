namespace LokLog.Application.Services;
using LokLog.Application.Interfaces;

internal class SecureOvertimeEntryService(ICurrentUserAccessor currentUser)
{
    private readonly ICurrentUserAccessor currentUser = currentUser;
}
