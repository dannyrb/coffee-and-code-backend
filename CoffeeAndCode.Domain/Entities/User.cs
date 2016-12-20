using System;
using CoffeeAndCode.Domain.Interfaces;

namespace CoffeeAndCode.Domain.Entities
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
    }
}
