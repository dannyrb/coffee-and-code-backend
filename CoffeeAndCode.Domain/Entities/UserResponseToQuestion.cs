using System;
using CoffeeAndCode.Domain.Interfaces;

namespace CoffeeAndCode.Domain.Entities
{
    public class UserResponseToQuestion: ITrackedEntity
    {
        public Guid Id { get; set; }

        // Ref
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public Guid OptionId { get; set; }
        public virtual QuestionOption Option { get; set; }

        //
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
    }
}
