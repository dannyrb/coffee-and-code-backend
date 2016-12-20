using System;
using CoffeeAndCode.Domain.Interfaces;

namespace CoffeeAndCode.Domain.Entities
{
    public class OptionValueType: INamedEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
