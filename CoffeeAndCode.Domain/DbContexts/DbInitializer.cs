using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeAndCode.Domain.Entities;

namespace CoffeeAndCode.Domain.DbContexts
{
    public static class DbInitializer
    {
        public static void Initialize(CoffeeAndCodeDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{FirstName= "Danny",LastName="Brown", CreatedDateTime=DateTime.Now, LastModifiedDateTime = DateTime.Now},
                new User{FirstName= "Austin",LastName="Murphy", CreatedDateTime=DateTime.Now, LastModifiedDateTime = DateTime.Now}
            };

            context.Users.AddRange(users);
            context.SaveChanges();


            var questions = new Question[]
            {
                new Question
                {
                    Id = Guid.Parse("9ac46873-46ca-4619-905a-e26ac8f07744"),
                    Name = "How much coffee did you just drink?",
                    AskedOnlyOnceDaily = false
                }
            };

            context.Questions.AddRange(questions);
            context.SaveChanges();


            var optionValueTypes = new OptionValueType[]
            {
                new OptionValueType {Id = Guid.Parse("ab151c4b-7dff-4150-866b-b190634b6bd6"), Name = "int"},
                new OptionValueType {Id = Guid.Parse("2c8fa2f3-9ef6-4f40-b0e0-afbafd674501"), Name = "bool"},
                new OptionValueType {Id = Guid.Parse("19b3022a-5b61-4e49-a11d-cf6951ecfbf9"), Name = "enum"}
            };

            context.ValueTypes.AddRange(optionValueTypes);
            context.SaveChanges();


            var questionOptions = new QuestionOption[]
            {
                new QuestionOption
                {
                    Id = Guid.Parse("2e48d4d5-2a9c-4338-8ebf-f3349ce247d6"),
                    Name = "4 oz",
                    Value = "4",
                    Unit = "oz",
                    ValueType = context.ValueTypes.Single(vt => vt.Id == Guid.Parse("ab151c4b-7dff-4150-866b-b190634b6bd6")),
                    Question = context.Questions.Single(q => q.Id == Guid.Parse("9ac46873-46ca-4619-905a-e26ac8f07744"))
                },
                new QuestionOption
                {
                    Id = Guid.Parse("88aaf4b7-377d-40ec-8a71-9f4ef86be85e"),
                    Name = "6 oz",
                    Value = "6",
                    Unit = "oz",
                    ValueType = context.ValueTypes.Single(vt => vt.Id == Guid.Parse("ab151c4b-7dff-4150-866b-b190634b6bd6")),
                    Question = context.Questions.Single(q => q.Id == Guid.Parse("9ac46873-46ca-4619-905a-e26ac8f07744"))
                }
            };

            context.Options.AddRange(questionOptions);
            context.SaveChanges();
        }
    }
}
