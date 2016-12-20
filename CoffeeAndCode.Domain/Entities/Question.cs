using System;
using System.Collections.Generic;
using CoffeeAndCode.Domain.Interfaces;

namespace CoffeeAndCode.Domain.Entities
{
    public class Question: INamedEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool AskedOnlyOnceDaily { get; set; }
        
        public virtual IEnumerable<QuestionOption> Options { get; set; }
    }
}
