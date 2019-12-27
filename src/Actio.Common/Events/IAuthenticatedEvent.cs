using System;

namespace Actio.Common.Events
{
    public class IAuthenticatedEvent : IEvent
    {
        Guid UserId { get; set; }
    }
}