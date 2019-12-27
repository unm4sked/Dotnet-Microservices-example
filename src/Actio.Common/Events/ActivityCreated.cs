using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; }
        public string Category { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime CreatedAt { get; }
        public Guid UserId { get; }

        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid id, string category, string name, string description, DateTime createdAt, Guid userId)
        {
            Id = id;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            UserId = userId;
        }
    }
}