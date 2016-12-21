using System;

namespace CoffeeAndCode.Domain.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }

        // todo: potentially pull out into ITrackedEntity
        DateTime CreatedDateTime { get; set; }
        DateTime LastModifiedDateTime { get; set; }
        DateTime? DeletedDateTime { get; set; }
    }
}
