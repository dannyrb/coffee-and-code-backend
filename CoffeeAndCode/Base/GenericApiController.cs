using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeAndCode.Domain.DbContexts;
using CoffeeAndCode.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeAndCode.Base
{
    // todo: Handle DTOs
    // todo: Handle Soft Delete
    public class GenericApiController<TEntity> : Controller // todo: IDto, IDetailDto
        where TEntity : class, IEntity, new ()
    {
        protected readonly CoffeeAndCodeDbContext Context;

        // Injection is handled for us; setup in startup.cs (:
        public GenericApiController(CoffeeAndCodeDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<List<TEntity>> Get()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }
    }
}
