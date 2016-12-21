using System;
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
    public class GenericApiController<TEntity, TDto, TDDto> : Controller // todo: IDto, IDetailDto
        where TEntity : class, IEntity, new ()
        where TDto : class, IDto, new()
        where TDDto : class, IDto, new()
    {
        protected readonly CoffeeAndCodeDbContext Context;
        protected readonly IMapper Mapper;

        // Injection is handled for us; setup in startup.cs (:
        public GenericApiController(IMapper mapper, CoffeeAndCodeDbContext context)
        {
            Mapper = mapper;
            Context = context;
        }

        // GET api/{{controller}}
        [HttpGet]
        public async Task<IEnumerable<TDto>> Get()
        {
            var dbResult = await Context.Set<TEntity>().ToListAsync();
            return Mapper.Map<IEnumerable<TDto>>(dbResult);
        }

        // GET api/{{controller}}/{{id}}
        [HttpGet("{id}")]
        public async Task<TDDto> Get(string id)
        {
            Guid idGuid;
            if (!Guid.TryParse(id, out idGuid)) { return new TDDto(); }
            var dbResult = await Context.Set<TEntity>().SingleOrDefaultAsync(usr => usr.Id == idGuid);
            return Mapper.Map<TDDto>(dbResult);
        }
    }
}
