using AutoMapper;
using CoffeeAndCode.Domain.Entities;
using CoffeeAndCode.Viewmodels.Dtos.User;

namespace CoffeeAndCode.Viewmodels.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Name, opt => 
                    opt.MapFrom(src => (src.FirstName ?? "") + " " + (src.LastName ?? " ")))
                ;
        }
    }
}
