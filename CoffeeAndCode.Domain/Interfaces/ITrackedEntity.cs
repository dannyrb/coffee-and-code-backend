using System;

namespace CoffeeAndCode.Domain.Interfaces
{
    public interface ITrackedEntity: IEntity
    {
        DateTime CreatedDateTime { get; set; }
        DateTime LastModifiedDateTime { get; set; }
        DateTime? DeletedDateTime { get; set; }
    }
}
