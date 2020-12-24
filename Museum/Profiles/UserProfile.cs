using AutoMapper;
using Museum.Dtos.User;
using MuseumData.Models;

namespace Museum.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Source -> Target
            CreateMap<User, UserReadDto>();
        }
    }
}