using CoffeeAndCode.Domain.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAndCode.Base
{
    public class BaseController: Controller
    {
        //private readonly CoffeeAndCodeDbContext _context;

        // Injection is handled for us; setup in startup.cs (:
        public BaseController()//CoffeeAndCodeDbContext context)
        {
            //_context = context;
        }
    }
}
