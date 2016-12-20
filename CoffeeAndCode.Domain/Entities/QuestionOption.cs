using System;
using CoffeeAndCode.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeAndCode.Domain.Entities
{
    public class QuestionOption: INamedEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Unit { get; set; }

        // Ref
        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid ValueTypeId { get; set; }
        public virtual OptionValueType ValueType { get; set; }
    }
}
