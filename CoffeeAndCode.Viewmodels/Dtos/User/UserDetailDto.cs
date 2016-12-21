using CoffeeAndCode.Viewmodels.Interfaces;

namespace CoffeeAndCode.Viewmodels.Dtos.User
{
    public class UserDetailDto : IDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
