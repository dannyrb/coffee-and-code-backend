using AutoMapper;
using CoffeeAndCode.Base;
using CoffeeAndCode.Domain.DbContexts;
using CoffeeAndCode.Domain.Entities;
using CoffeeAndCode.Viewmodels.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAndCode.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : GenericApiController<User, UserDto, UserDetailDto>
    {
        public UsersController(IMapper mapper, CoffeeAndCodeDbContext context)
            : base(mapper, context) { }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
