using System;
using CoffeeAndCode.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeAndCode.Domain.Entities
{
    public class UserResponseToQuestion: IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTime { get; set; }

        // Ref
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid OptionId { get; set; }
        public virtual QuestionOption Option { get; set; }
    }
}
