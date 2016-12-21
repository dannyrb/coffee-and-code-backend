using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CoffeeAndCode.Domain.DbContexts;
using CoffeeAndCode.Domain.Interfaces;
using CoffeeAndCode.Viewmodels.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeAndCode.Base
{
    // todo: Handle DTOs
    // todo: Handle Soft Delete
    public class GenericApiController<TEntity, Dto> : Controller // todo: IDto, IDetailDto
        where TEntity : class, IEntity, new ()
        where Dto : class, IDto, new()
    {
        protected readonly CoffeeAndCodeDbContext Context;

        // Injection is handled for us; setup in startup.cs (:
        public GenericApiController(CoffeeAndCodeDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Dto>> Get()
        {
            var dbResult = await Context.Set<TEntity>().ToListAsync();
            return Mapper.Map<IEnumerable<Dto>>(dbResult);
        }
    }
}
