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
    public class GenericTrackedApiController<TTrackedEntity, TDto, TDDto> : GenericApiController<TTrackedEntity, TDto, TDDto>
        where TTrackedEntity : class, ITrackedEntity, new()
        where TDto : class, IDto, new()
        where TDDto : class, IDto, new()
    {
        // Injection is handled for us; setup in startup.cs (:
        public GenericTrackedApiController(IMapper mapper, CoffeeAndCodeDbContext context)
            :base(mapper, context)
        {
        }

        // DELETE api/{{controller}}/{{id}}
        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            Guid idGuid;
            if (!Guid.TryParse(id, out idGuid)) { } // return new TDDto(); }
            var dbResult = await Context.Set<TTrackedEntity>().SingleOrDefaultAsync(usr => usr.Id == idGuid);
            if (dbResult != null)
            {
                dbResult.DeletedDateTime = DateTime.Now;
                Context.SaveChanges();
            }
        }
    }
}
